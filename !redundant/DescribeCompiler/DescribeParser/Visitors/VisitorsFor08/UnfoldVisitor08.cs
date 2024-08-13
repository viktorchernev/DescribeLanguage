﻿using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DescribeParser.Unfold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace DescribeParser.Visitors
{
    /// <summary>
    /// This visitor class is used extract data and store it in an <see cref="DescribeUnfold"/>.
    /// For Describe Language version 0.8
    /// </summary>
    public class UnfoldVisitor08
    {
        // Misc
        private static Random random = new Random();
        private static string getRandomString(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        /// <summary>
        /// Ctor.
        /// </summary>
        public UnfoldVisitor08()
        {
            _log = "";
            _lerror = null;
        }

        string _log;
        string? _lerror;

        /// <summary>
        /// Gets or sets all the logs for this instance.
        /// </summary>
        public string Log
        {
            get
            {
                return _log;
            }
            set
            {
                Validators.ValidateString(value);
                _log = value;
            }
        }

        /// <summary>
        /// Gets the last error for this instance. 
        /// If there was an error, this string contains the message, 
        /// and if there weren't any errors, this will be `null`.
        /// </summary>
        public string? LastError
        {
            get
            {
                return _lerror;
            }
            set
            {
                _lerror = value;
            }
        }



        /// <summary>
        /// Translate ANTLR4 parser parse tree (root ScriptureContext context) to Unfold structure.
        /// "scripture : expression_list EOF | expression EOF;"
        /// </summary>
        /// <param name="u">Unfold to be populated</param>
        /// <param name="context">Root context produced by the parser aka the parse tree</param>
        /// <param name="filename">The filename for the operation.</param>
        /// <returns>True if successful</returns>
        public bool TranslateScripture(DescribeUnfold u, Describe08Parser.ScriptureContext context, string filename = "")
        {
            Validators.ValidateUnfold(u);
            Validators.ValidateParserRuleContext(context);
            Validators.ValidateString(filename);

            //reset namespace for the file
            u.ParseJob.LastNamespace = "";
            u.ParseJob.LastFile = filename == null ? "" : filename;

            //if we have no productions whatsoever
            //then this must be the primary file
            bool isPrimary = u.Productions.Count == 0;

            //Unfold the scripture
            IParseTree child = context.GetChild(0);
            if (child is Describe08Parser.ExpressionContext)
            {
                string key2 = DoExpression(u, (child as Describe08Parser.ExpressionContext)!);
                if (isPrimary) u.PrimaryProductions.Add(key2);
                return true;
            }
            else if (child is Describe08Parser.Expression_listContext)
            {
                string[] keys = DoExpressionList(u, (child as Describe08Parser.Expression_listContext)!, true);
                if (isPrimary)
                {
                    for (int i = 0; i < keys.Length; i++)
                    {
                        u.PrimaryProductions.Add(keys[i]);
                    }
                }
                return true;
            }
            return false;
        }



        /// <summary>
        /// Translate ANTLR4 parser expression_list to Unfold structure.
        /// "expression_list : expression+ expression;"
        /// </summary>
        private string[] DoExpressionList(DescribeUnfold u, Describe08Parser.Expression_listContext context, bool isPrimery = false)
        {
            int childCount = context.ChildCount;
            var firstChild = context.GetChild(0) as Describe08Parser.ExpressionContext;
            if (firstChild == null)
            {
                throw new ArgumentException(
                    "The first child of the provided Expression_listContext is not a valid ExpressionContext.",
                    nameof(context));
            }
            string key1 = DoExpression(u, firstChild);

            //We want to find out now if this first expression in the expression list
            //is not a preprocessor dirrectives expression
            //isPrimery meant that it is expressionList directly in the scripture
            //element - where we might find valid nammespace directive
            bool removeKey = false;
            if (isPrimery)
            {
                //setup the Namespace field in the unfold
                //production literal is "directives" or "DIRECTIVES".
                //if we have only one production then we won't be doing this check
                //for now and just parse it, be it a directive
                string literal = u.Translations[key1];
                if (literal == "directives" || literal == "DIRECTIVES")
                {
                    List<string> directives = u.Productions[key1];
                    foreach (string directive in directives)
                    {
                        string keyword = u.Translations[directive];
                        if (keyword == "namespace") u.ParseJob.LastNamespace = directive;
                        u.Translations.Remove(directive);
                    }

                    u.Translations.Remove(key1);
                    u.Productions.Remove(key1);
                    u.PrimaryProductions.Remove(key1);
                    removeKey = true;
                }
            }

            // deal with the rest of the children
            List<string> keys = new List<string>();
            if (removeKey == false) keys.Add(key1);
            for (int i = 1; i < childCount; i++)
            {
                var child = context.GetChild(i) as Describe08Parser.ExpressionContext;
                if (child == null)
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided Expression_listContext is not a valid ExpressionContext.",
                        nameof(context));
                }
                string key = DoExpression(u, child);
                keys.Add(key);
            }

            //return
            return keys.ToArray();
        }

        /// <summary>
        /// "item_or_expression_list : (item_or_expression_part)+ item"
        ///	"item_or_expression_list : (item_or_expression_part)+ expression ;"
        ///	"item_or_expression_part : item SEPARATOR"
        /// "item_or_expression_part : expression (SEPARATOR)? ;"
        /// </summary>
        private string[] DoItemOrExpressionList(DescribeUnfold u, Describe08Parser.Item_or_expression_listContext context)
        {
            int childCount = context.ChildCount;
            List<string> keys = new List<string>();

            //deal with item_or_expression_part
            for (int i = 0; i < childCount - 1; i++)
            {
                var ch = context.GetChild(i) as Describe08Parser.Item_or_expression_partContext;
                if (ch == null)
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided Item_or_expression_listContext is not a valid Item_or_expression_partContext.",
                        nameof(context));
                }
                var child = ch.GetChild(0);
                if (child is Describe08Parser.ItemContext)
                {
                    string k = DoItem(u, (child as Describe08Parser.ItemContext)!);
                    keys.Add(k);
                }
                else if (child is Describe08Parser.ExpressionContext)
                {
                    string k = DoExpression(u, (child as Describe08Parser.ExpressionContext)!);
                    keys.Add(k);
                }
                else
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided Item_or_expression_listContext is not valid.",
                        nameof(context));
                }
            }

            //deal with last child
            var lastChild = context.GetChild(childCount - 1);
            if (lastChild is Describe08Parser.ItemContext)
            {
                string k = DoItem(u, (lastChild as Describe08Parser.ItemContext)!);
                keys.Add(k);
            }
            else if (lastChild is Describe08Parser.ExpressionContext)
            {
                string k = DoExpression(u, (lastChild as Describe08Parser.ExpressionContext)!);
                keys.Add(k);
            }
            else
            {
                throw new ArgumentException(
                    $"The last child of the provided Item_or_expression_listContext is not valid.",
                    nameof(context));
            }

            //return
            return keys.ToArray();
        }

        /// <summary>
        /// Translate ANTLR4 parser expression to Unfold structure.
        /// "expression : item producer item_or_expression_list TERMINATOR"
        /// "expression : item producer item TERMINATOR"
        /// "expression : item producer expression TERMINATOR"
        /// "expression : item producer TERMINATOR ;"
        /// </summary>
        private string DoExpression(DescribeUnfold u, Describe08Parser.ExpressionContext context)
        {
            int childCount = context.ChildCount;
            var firstChild = context.GetChild(0) as Describe08Parser.ItemContext;
            if (firstChild == null)
            {
                throw new ArgumentException(
                    $"The first child of the provided ExpressionContext is not a valid ItemContext.",
                    nameof(context));
            }
            string head = DoItem(u, firstChild);

            //find out which kind of expression we have
            var thirdChild = context.GetChild(2);

            //empty production treated as item.
            //We believe that thirdChild is "TERMINATOR" here
            if (thirdChild is ITerminalNode)
            {
                //u.Productions.Add(head, new List<string>());
            }

            //otherwise continue as normal production
            else if (thirdChild is Describe08Parser.ItemContext)
            {
                string right = DoItem(u, (thirdChild as Describe08Parser.ItemContext)!);

                //check for id collision item with same id is redefinition,
                //but 2 productions heads with same id is collision
                if (u.Productions.ContainsKey(head))
                {
                    string item = u.Translations[head] + " <" + head + ">";
                    string prodfile = u.ProdidFile[head][0];
                    string message = "Collision! Item \"" + item +
                        "\" - there is production head with the same id in file: \"" +
                        prodfile + "\"";
                    throw new Exception(message);
                }
                u.Productions.Add(head, new List<string>() { right });
            }
            else if (thirdChild is Describe08Parser.ExpressionContext)
            {
                string right = DoExpression(u, (thirdChild as Describe08Parser.ExpressionContext)!);
                //check for id collision item with same id is redefinition,
                //but 2 productions heads with same id is collision
                if (u.Productions.ContainsKey(head))
                {
                    string item = u.Translations[head] + " <" + head + ">";
                    string prodfile = u.ProdidFile[head][0];
                    string message = "Collision! Item \"" + item +
                        "\" - there is production head with the same id in file: \"" +
                        prodfile + "\"";
                    throw new Exception(message);
                }
                u.Productions.Add(head, new List<string>() { right });
            }
            else if (thirdChild is Describe08Parser.Item_or_expression_listContext)
            {
                string[] rights = DoItemOrExpressionList(u, (thirdChild as Describe08Parser.Item_or_expression_listContext)!);
                //check for id collision item with same id is redefinition,
                //but 2 productions heads with same id is collision
                if (u.Productions.ContainsKey(head))
                {
                    string item = u.Translations[head] + " <" + head + ">";
                    string prodfile = u.ProdidFile[head][0];
                    string message = "Collision! Item \"" + item +
                        "\" - there is production head with the same id in file: \"" +
                        prodfile + "\"";
                    throw new Exception(message);
                }
                u.Productions.Add(head, rights.ToList());
            }
            else
            {
                throw new ArgumentException(
                    $"The third child of the provided ExpressionContext is not a valid ItemContext.",
                    nameof(thirdChild));
            }

            //idFile
            string cf = u.ParseJob.LastFile!;
            if (string.IsNullOrEmpty(cf)) cf = "NA";
            if (u.ProdidFile.ContainsKey(head) == false)
            {
                u.ProdidFile.Add(head, new List<string>() { cf });
            }
            else
            {
                u.ProdidFile[head].Add(cf);
            }

            return head;
        }

        /// <summary>
        /// "item : (text_chunk)+ (TAG)?"
		/// "item : (text_chunk)+ (LINK)+"
		/// "item :  (text_chunk)+ (LINK)+ TAG"
		/// "item :  (text_chunk)+ TAG (LINK)+ ;"
        /// </summary>
        private string DoItem(DescribeUnfold u, Describe08Parser.ItemContext context)
        {
            int childCount = context.ChildCount;
            string text = "";
            string tag = "";
            List<string> links = new List<string>();
            for (int i = 0; i < childCount; i++)
            {
                var child = context.GetChild(i);
                if (child == null)
                {
                    throw new ArgumentException(
                        $"The child at index {i} of the provided ItemContext is not valid.",
                        nameof(child));
                }
                else if (child is Describe08Parser.Text_chunkContext)
                {
                    ITerminalNode? token = (child as Describe08Parser.Text_chunkContext)?.GetChild(0) as ITerminalNode;
                    if (token == null)
                    {
                        throw new ArgumentException(
                        $"The child at index {i} of the provided ItemContext is not valid.",
                        nameof(token));
                    }
                    string s = token.GetText();
                    text += s;
                }
                else if(child is ITerminalNode)
                {
                    ITerminalNode token = (child as ITerminalNode)!;
                    string type = GetTokenType(token.Symbol.Type);
                    string s = token.GetText();
                    if (type == "TAG")
                    {
                        s = s.Trim();
                        s = s.Substring(1, s.Length - 2);
                        tag = s.Trim();
                    }
                    else if (type == "LINK")
                    {
                        s = s.Trim();
                        s = s.Substring(1, s.Length - 2);
                        s = s.Trim();
                        if (!string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s))
                        {
                            links.Add(s);
                        }
                    }
                }
            }
            text = text.Trim();

            //tag
            if(tag == "") tag = getRandomString();
            if (!u.Translations.Keys.Contains(tag))
            {
                u.Translations.Add(tag, text);
            }
            else
            {
                //redefinition
                u.Translations[tag] = text;
            }

            //links
            if (!u.Links.Keys.Contains(tag))
            {
                u.Links.Add(tag, new List<DescribeLink>());
            }
            if (links.Count() > 0)
            {
                foreach (string link in links)
                {
                    int pipeIndex = link.IndexOf('|');
                    if (pipeIndex <= 0)
                    {
                        DescribeLink l = new DescribeLink();
                        l.Url = link;
                        u.Links[tag].Add(l);
                    }
                    else
                    {
                        string url = link.Substring(0, pipeIndex).Trim();
                        string title = link.Substring(pipeIndex + 1).Trim();
                        DescribeLink l = new DescribeLink();
                        l.Url = url; l.Title = title;
                        u.Links[tag].Add(l);
                    }
                }
            }

            //add empty items for tags and decorators anyways
            //in order to initialize them and not have nulls
            if (!u.Links.Keys.Contains(tag))
            {
                u.Links.Add(tag, new List<DescribeLink>());
            }
            if (!u.Decorators.Keys.Contains(tag))
            {
                u.Decorators.Add(tag, new List<DescribeDecorator>());
            }

            //idFile
            string cf = u.ParseJob.LastFile!;
            if (string.IsNullOrEmpty(cf)) cf = "NA";
            if (u.ItemidFile.ContainsKey(tag) == false)
            {
                u.ItemidFile.Add(tag, new List<string>() { cf });
            }
            else
            {
                u.ItemidFile[tag].Add(cf);
            }

            return tag;
        }



        static string GetTokenType(int tokenType)
        {
            return Describe08Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
    }
}
