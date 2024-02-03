---
layout: page
title: Describe Compiler - Versioning
permalink: /describe-compiler-versioning-pdf/
exclude: true
---

The Describe Compiler project uses semantic versioning. The Describe compiler is currently in a version 0.9 which is an open beta. 


# change-log

## Compiler v0.9
## Compiler v0.9.1
## Compiler v0.9.2
## Compiler v0.9.3
## Compiler v0.9.4





# history
First, a simple and rudimentary mock application was hacked together, that was called "Test Gadget". It had no real parser engine and used simple logic. In time it grew in complexity and became the Describe Compiler. Below is the source code, as a curiosity.

### TestGadget v3

```
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gtk;

namespace TOATg
{
    public static class TestGadget3
    {
        public static Dictionary<string, List<string>> Productions;
        public static Dictionary<string, string> Translations;
        public static Dictionary<string, string> Files;


        static TestGadget3()
        {
            Translations = new Dictionary<string, string>();
            Files = new Dictionary<string, string>();
            Productions = new Dictionary<string, List<string>>();
        }


        public static void ParseTextFile(string filename)
        {
            string filetext = ReadTextFile(filename);
            List<string> productions = GetProductions(filetext);
            foreach (string prod in productions)
            {
                ParseProduction(prod);
            }
        }
        public static void ParseTextFiles(string filename)
        {
            List<string> parsedFiles = new List<string>();

            string cur = filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if(filetext != null)
                {
                    List<string> productions = GetProductions(filetext);
                    foreach (string prod in productions)
                    {
                        ParseProduction(prod);
                    }
                }

                cur = "";
                foreach (string s in Files.Values)
                {
                    if (parsedFiles.Contains(@"/home/viktor/Desktop/tree2/" + s) == false)
                    {
                        cur = @"/home/viktor/Desktop/tree2/" + s;
                        break;
                    }
                }
            }
        }

        public static void WriteTree()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter;


            foreach (KeyValuePair<string, List<string>> kvp in Productions)
            {
                treeIter = treeStore.AppendValues(Translations[kvp.Key]);
                for (int j = 0; j < Productions[kvp.Key].Count; j++)
                {
                    string code = Productions[kvp.Key][j];
                    TreeIter newIter = treeStore.AppendValues(treeIter, Translations[code]);
                }
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteList()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter;


            //Productions["rootnode"]

            foreach (KeyValuePair<string, List<string>> kvp in Productions)
            {
                treeIter = treeStore.AppendValues(Translations[kvp.Key]);
                for (int j = 0; j < Productions[kvp.Key].Count; j++)
                {
                    string code = Productions[kvp.Key][j];
                    string text = "NULL";
                    if (code != null) text = Translations[code];
                    treeStore.AppendValues(treeIter, text);
                }
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteTree2()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter = treeStore.AppendValues(Translations["rootnode"]);
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null) text = Translations[code];
                TreeIter newIter = treeStore.AppendValues(treeIter, text);
                AddLayer(treeStore, newIter, code);
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteTree2(Window window)
        {
            // Make new window
            //Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter = treeStore.AppendValues(Translations["rootnode"]);
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null) text = Translations[code];
                TreeIter newIter = treeStore.AppendValues(treeIter, text);
                AddLayer(treeStore, newIter, code);
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        static void AddLayer(TreeStore store, TreeIter iter, string code)
        {
            if (Productions.ContainsKey(code) == false) return;


            List<string> ps = Productions[code];
            for (int j = 0; j < ps.Count; j++)
            {
                string text = "NULL";
                if (ps[j] != null) text = Translations[ps[j]];
                TreeIter newIter = store.AppendValues(iter, text);
                AddLayer(store, newIter, ps[j]);
            }
        }

        static void ParseProduction(string production)
        {
            string[] sides = production.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sides.Length; i++) sides[i] = sides[i].Trim();

            string lhs = sides[0];
            if (string.IsNullOrEmpty(lhs) || string.IsNullOrWhiteSpace(lhs)) return;

            List<string> rhs = new List<string>();
            if (sides.Length > 1)
            {
                rhs = sides[1]
                    .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                for (int i = 0; i < rhs.Count; i++) rhs[i] = rhs[i].Trim();
            }

            string lcode = ParseTranslation(lhs);
            List<string> rcodes = new List<string>();
            foreach (string stat in rhs)
            {
                string rcode = ParseTranslation(stat);
                rcodes.Add(rcode);
            }
            Productions.Add(lcode, rcodes);
        }
        static string ParseTranslation(string statement)
        {
            if (!statement.Contains('<')) return null;
            if (!statement.Contains('<')) return null;

            string[] sides = statement.Split('<');
            string text = sides[0].Trim();

            string code = sides[1].Split('>')[0];
            if(code.Contains('/') && code.Length == 17)
            {
                string[] sep = code.Split('/');
                code = sep[1];
                string file = sep[0];
                if(!Files.ContainsKey(code)) Files.Add(code, file);
            }
            if (!Translations.ContainsKey(code)) Translations.Add(code, text);
            return code;
        }

        static List<string> GetProductions(string filetext)
        {
            string[] productions = filetext.Split(
                new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> li = new List<string>();
            foreach (string p in productions)
            {
                if(!string.IsNullOrEmpty(p) && !string.IsNullOrWhiteSpace(p))
                {
                    li.Add(p.Trim());
                }
            }

            return li;
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }
    }
}

// TODO: Take into account escape sequences - \; \, \< \>
// TODO: Fix reworded "," with "and" and "or"

```

### TestGadget v4

```
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Gtk;

namespace TOATg
{
    public static class TestGadget3
    {
        public static Dictionary<string, List<string>> Productions;
        public static Dictionary<string, string> Translations;
        public static Dictionary<string, string> Files;


        static TestGadget3()
        {
            Translations = new Dictionary<string, string>();
            Files = new Dictionary<string, string>();
            Productions = new Dictionary<string, List<string>>();
        }


        public static void ParseTextFile(string filename)
        {
            string filetext = ReadTextFile(filename);
            List<string> productions = GetProductions(filetext);
            foreach (string prod in productions)
            {
                ParseProduction(prod);
            }
        }
        public static void ParseTextFiles(string path, string filename)
        {
            List<string> parsedFiles = new List<string>();

            string cur = path + filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if(filetext != null)
                {
                    List<string> productions = GetProductions(filetext);
                    foreach (string prod in productions)
                    {
                        ParseProduction(prod);
                    }
                }

                cur = "";
                foreach (string s in Files.Values)
                {
                    if (parsedFiles.Contains(path + s) == false)
                    {
                        cur = path + s;
                        break;
                    }
                }
            }
        }

        public static void WriteTree()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter;


            foreach (KeyValuePair<string, List<string>> kvp in Productions)
            {
                treeIter = treeStore.AppendValues(Translations[kvp.Key]);
                for (int j = 0; j < Productions[kvp.Key].Count; j++)
                {
                    string code = Productions[kvp.Key][j];
                    TreeIter newIter = treeStore.AppendValues(treeIter, Translations[code]);
                }
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteList()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter;


            //Productions["rootnode"]

            foreach (KeyValuePair<string, List<string>> kvp in Productions)
            {
                treeIter = treeStore.AppendValues(Translations[kvp.Key]);
                for (int j = 0; j < Productions[kvp.Key].Count; j++)
                {
                    string code = Productions[kvp.Key][j];
                    string text = "NULL";
                    if (code != null) text = Translations[code];
                    treeStore.AppendValues(treeIter, text);
                }
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteTree2()
        {
            // Make new window
            Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter = treeStore.AppendValues(Translations["rootnode"]);
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null) text = Translations[code];
                TreeIter newIter = treeStore.AppendValues(treeIter, text);
                AddLayer(treeStore, newIter, code);
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        public static void WriteTree2(Window window)
        {
            // Make new window
            //Gtk.Window window = new Gtk.Window("TreeView Example");
            window.SetSizeRequest(800, 600);

            // Create tree view
            Gtk.TreeView tree = new Gtk.TreeView();
            window.Add(tree);

            // Set columns - at this case 1 column
            TreeViewColumn column_1 = new TreeViewColumn();
            CellRendererText crt_1 = new CellRendererText();
            column_1.PackStart(crt_1, true);
            tree.AppendColumn(column_1);
            column_1.AddAttribute(crt_1, "text", 0);

            // Set content
            TreeStore treeStore = new TreeStore(typeof(string), typeof(string));
            TreeIter treeIter = treeStore.AppendValues(Translations["rootnode"]);
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null) text = Translations[code];
                TreeIter newIter = treeStore.AppendValues(treeIter, text);
                AddLayer(treeStore, newIter, code);
            }

            tree.Model = treeStore;
            window.ShowAll();
        }
        static void AddLayer(TreeStore store, TreeIter iter, string code)
        {
            if (Productions.ContainsKey(code) == false) return;


            List<string> ps = Productions[code];
            for (int j = 0; j < ps.Count; j++)
            {
                string text = "NULL";
                if (ps[j] != null) text = Translations[ps[j]];
                TreeIter newIter = store.AppendValues(iter, text);
                AddLayer(store, newIter, ps[j]);
            }
        }

        static void ParseProduction(string production)
        {
            string[] sides = production.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sides.Length; i++) sides[i] = sides[i].Trim();

            string lhs = sides[0];
            if (string.IsNullOrEmpty(lhs) || string.IsNullOrWhiteSpace(lhs)) return;

            List<string> rhs = new List<string>();
            if (sides.Length > 1)
            {
                rhs = Regex.Split(sides[1], @"(?<!($|[^\\])(\\\\)*?\\),").ToList();
                for (int i = 0; i < rhs.Count; i++)
                {
                    rhs[i] = rhs[i].Trim();
                    rhs[i] = rhs[i].Replace("\\,", ","); 
                    //should use regex to match possible number of escaped escape backslashes
                }
            }

            string lcode = ParseTranslation(lhs);
            List<string> rcodes = new List<string>();
            foreach (string stat in rhs)
            {
                string rcode = ParseTranslation(stat);
                rcodes.Add(rcode);
            }
            Productions.Add(lcode, rcodes);
        }
        static string ParseTranslation(string statement)
        {
            if (!statement.Contains('<')) return null;
            if (!statement.Contains('<')) return null;

            string[] sides = statement.Split('<');
            string text = sides[0].Trim();

            string code = sides[1].Split('>')[0];
            if(code.Contains('/') && code.Length == 17)
            {
                string[] sep = code.Split('/');
                code = sep[1];
                string file = sep[0];
                if(!Files.ContainsKey(code)) Files.Add(code, file);
            }
            if (!Translations.ContainsKey(code)) Translations.Add(code, text);
            return code;
        }

        static List<string> GetProductions(string filetext)
        {
            string[] productions = filetext.Split(
                new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> li = new List<string>();
            foreach (string p in productions)
            {
                if(!string.IsNullOrEmpty(p) && !string.IsNullOrWhiteSpace(p))
                {
                    li.Add(p.Trim());
                }
            }

            return li;
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }
    }
}

// TODO: Take into account escape sequences - \; \, \< \> \->
// TODO: Use regex to match possible number of escaped backslashes in ParseProduction(string)
// TODO: Fix reworded "," with "and" and "or"
```

### TestGadget v4.1

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGadget
{
    public static class TestGadget
    {
        public static Dictionary<string, List<string>> Productions;
        public static Dictionary<string, string> Translations;
        public static Dictionary<string, string> Files;

        static TestGadget()
        {
            Translations = new Dictionary<string, string>();
            Files = new Dictionary<string, string>();
            Productions = new Dictionary<string, List<string>>();
        }



        public static void WriteTree(TreeView tree)
        {
            for (int j = 0; j < Productions["rootnode"].Count; j++)
            {
                string code = Productions["rootnode"][j];
                string text = "NULL";
                if (code != null)
                {
                    text = Translations[code];
                    var node = tree.Nodes.Add(text);
                    AddLayer(node, code);
                }
            }
        }
        static void AddLayer(TreeNode node, string code)
        {
            if (Productions.ContainsKey(code) == false) return;

            List<string> ps = Productions[code];
            for (int j = 0; j < ps.Count; j++)
            {
                string text = "NULL";
                if (ps[j] != null)
                {
                    text = Translations[ps[j]];
                    var n = node.Nodes.Add(text);
                    AddLayer(n, ps[j]);
                }
            }
        }



        public static void ParseTextFile(string filename)
        {
            string filetext = ReadTextFile(filename);
            List<string> productions = GetProductions(filetext);
            foreach (string prod in productions)
            {
                ParseProduction(prod);
            }
        }
        public static void ParseTextFiles(string path, string filename)
        {
            List<string> parsedFiles = new List<string>();

            string cur = path + filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if (filetext != null)
                {
                    List<string> productions = GetProductions(filetext);
                    foreach (string prod in productions)
                    {
                        ParseProduction(prod);
                    }
                }

                cur = "";
                foreach (string s in Files.Values)
                {
                    if (parsedFiles.Contains(path + s) == false)
                    {
                        cur = path + s;
                        break;
                    }
                }
            }
        }

        static void ParseProduction(string production)
        {
            string[] sides = production.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sides.Length; i++) sides[i] = sides[i].Trim();

            string lhs = sides[0];
            if (string.IsNullOrEmpty(lhs) || string.IsNullOrWhiteSpace(lhs)) return;

            List<string> rhs = new List<string>();
            if (sides.Length > 1)
            {
                rhs = Regex.Split(sides[1], @"(?<!($|[^\\])(\\\\)*?\\),").ToList();
                for (int i = 0; i < rhs.Count; i++)
                {
                    rhs[i] = rhs[i].Trim();
                    rhs[i] = rhs[i].Replace("\\,", ",");
                    //should use regex to match possible number of escaped escape backslashes
                }
            }

            string lcode = ParseTranslation(lhs);
            List<string> rcodes = new List<string>();
            foreach (string stat in rhs)
            {
                string rcode = ParseTranslation(stat);
                rcodes.Add(rcode);
            }
            Productions.Add(lcode, rcodes);
        }
        static string ParseTranslation(string statement)
        {
            if (!statement.Contains('<')) return null;
            if (!statement.Contains('<')) return null;

            string[] sides = statement.Split('<');
            string text = sides[0].Trim();

            string code = sides[1].Split('>')[0];
            if (code.Contains('/') && code.Length == 17)
            {
                string[] sep = code.Split('/');
                code = sep[1];
                string file = sep[0];
                if (!Files.ContainsKey(code)) Files.Add(code, file);
            }
            if (!Translations.ContainsKey(code)) Translations.Add(code, text);
            return code;
        }

        static List<string> GetProductions(string filetext)
        {
            string[] productions = filetext.Split(
                new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> li = new List<string>();
            foreach (string p in productions)
            {
                if (!string.IsNullOrEmpty(p) && !string.IsNullOrWhiteSpace(p))
                {
                    li.Add(p.Trim());
                }
            }

            return li;
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }
    }
}
```

### TestGadget v5

```
using GOLD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGadget
{
    public static class TestGadget
    {
        static TestGadget()
        {
            MyParser = new MyParserClass();
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
        }



        public static void WriteTree(TreeView tree)
        {
            for (int j = 0; j < MyParser.Productions["rootnode"].Count; j++)
            {
                string code = MyParser.Productions["rootnode"][j];
                string text = "NULL";
                if (code != null)
                {
                    text = MyParser.Translations[code];
                    var node = tree.Nodes.Add(text);
                    AddLayer(node, code);
                }
            }
        }
        static void AddLayer(TreeNode node, string code)
        {
            if (MyParser.Productions.ContainsKey(code) == false) return;

            List<string> ps = MyParser.Productions[code];
            for (int j = 0; j < ps.Count; j++)
            {
                string text = "NULL";
                if (ps[j] != null)
                {
                    text = MyParser.Translations[ps[j]];
                    var n = node.Nodes.Add(text);
                    AddLayer(n, ps[j]);
                }
            }
        }



        public static void LoadGrammer(string path)
        {
            try
            {
                if (MyParser.Setup(path))
                {
                    //MessageBox.Show("CGT loaded");
                }
                else
                {
                    MessageBox.Show("CGT failed to load");
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ParseTextFile(string filename)
        {
            if (MyParser.Loaded == false) return;
            string filetext = ReadTextFile(filename);
            if (filetext == null || string.IsNullOrWhiteSpace(filetext)) return;
            ParseSource(filename);
        }
        public static void ParseTextFiles(string path, string filename)
        {
            if (MyParser.Loaded == false) return;
            List<string> parsedFiles = new List<string>();

            string cur = path + filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if (filetext == null || string.IsNullOrWhiteSpace(filetext)) continue;
                ParseSource(cur);

                cur = "";
                foreach (string s in MyParser.Files.Values)
                {
                    if (parsedFiles.Contains(path + s) == false)
                    {
                        cur = path + s;
                        break;
                    }
                }
            }
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }



        static MyParserClass MyParser;
        static void ParseSource(string path)
        {
            try
            {
                string text = File.ReadAllText(path);
                StringReader reader = new StringReader(text);
                bool result = MyParser.Parse(reader);
                if (result)
                {
                    //MessageBox.Show(path + " parsed successfully!");
                }
                else
                {
                    MessageBox.Show(path + Environment.NewLine + MyParser.FailMessage);
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    internal class MyParserClass
    {
        public bool Loaded = false;
        private GOLD.Parser parser = new GOLD.Parser();
        public GOLD.Reduction? Root = null;//hacked to be nullable, it wasn't
        public string FailMessage = "";

        public bool Setup(string FilePath)
        {
            Loaded = parser.LoadTables(FilePath);
            return Loaded;
        }
        public bool Parse(TextReader reader)
        {
            GOLD.ParseMessage response;
            bool done = false;
            bool accepted = false;

            parser.Open(reader);
            parser.TrimReductions = false;

            while (!done)
            {
                response = parser.Parse();
                switch (response)
                {
                    case GOLD.ParseMessage.LexicalError:
                        //Cannot recognize token
                        FailMessage = "Lexical Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data;
                        done = true;
                        break;

                    case GOLD.ParseMessage.SyntaxError:
                        //Expecting a different token
                        FailMessage = "Syntax Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data + "\n" +
                                      "Expecting: " + parser.ExpectedSymbols().Text();
                        done = true;
                        break;

                    case GOLD.ParseMessage.Reduction:
                        //Populate dictionaries
                        Populate(parser.CurrentReduction);
                        break;

                    case GOLD.ParseMessage.Accept:
                        //Accepted!
                        Root = (GOLD.Reduction)parser.CurrentReduction;    //The root node!                                  
                        done = true;
                        accepted = true;
                        break;

                    case GOLD.ParseMessage.TokenRead:
                        //You don't have to do anything here.
                        break;

                    case GOLD.ParseMessage.InternalError:
                        //INTERNAL ERROR! Something is horribly wrong.
                        done = true;
                        break;

                    case GOLD.ParseMessage.NotLoadedError:
                        //This error occurs if the CGT was not loaded.                   
                        FailMessage = "Tables not loaded";
                        done = true;
                        break;

                    case GOLD.ParseMessage.GroupError:
                        //GROUP ERROR! Unexpected end of file
                        FailMessage = "Runaway group";
                        done = true;
                        break;
                }
            }
            return accepted;
        }


        public Dictionary<string, List<string>> Productions = new Dictionary<string, List<string>>();
        public Dictionary<string, string> Translations = new Dictionary<string, string>();
        public Dictionary<string, string> Files = new Dictionary<string, string>();


        void Populate(object o)
        {
            Reduction r = (Reduction)o;
            string ruleName = GetRuleName(r);


            if (ruleName == "item")
            {
                Item? item = GetItem(r);
                if (item == null) return;

                if (item.Tag.FileId != null)
                {
                    if (Files.ContainsKey(item.Tag.Id) == false)
                    {
                        Files.Add(item.Tag.Id, item.Tag.FileId);
                    }
                }
                if (Translations.ContainsKey(item.Tag.Id) == false)
                {
                    Translations.Add(item.Tag.Id, item.Literal);
                }
            }
            else if (ruleName == "expression")
            {
                Reduction litem = (Reduction)r.get_Data(0);
                Item? lit = GetItem(litem);
                if (lit == null) return;


                var next = r.get_Data(2);
                if(next is Reduction == false) return;
                Reduction ritem = (Reduction)next;
                string rule = ritem.Parent.Head().Name();
                if (rule == "item")
                {
                    Item? rit = GetItem(ritem);
                    if (rit == null) return;
                    List<string> rcodes = new List<string>() { rit.Tag.Id };
                    Productions.Add(lit.Tag.Id, rcodes);
                }
                else if (rule == "itemlist")
                {
                    List<Reduction>? reductions = UnwindItemlist(ritem);
                    if (reductions == null) return;

                    List<Item> items = new List<Item>();
                    foreach (Reduction red in reductions)
                    {
                        if (red == null) continue;
                        Item? item = GetItem(red);
                        if (item == null) continue;
                        items.Add(item);
                    }
                    List<string> rcodes = new List<string>();
                    foreach (Item it in items)
                    {
                        rcodes.Add(it.Tag.Id);
                    }
                    Productions.Add(lit.Tag.Id, rcodes);
                }
            }
        }

        Item? GetItem(Reduction r)
        {
            string name = GetRuleName(r);
            if (name != "item") return null;

            Tag? t = getTag(r);
            string literal = (string)r.get_Data(0);

            return new Item(literal, t);
        }
        Tag? getTag(Reduction r)
        {
            string name = GetRuleName(r);
            if (name != "item") return null;

            Reduction rtag = (Reduction)r.get_Data(1);          //get tag from "item"

            if (rtag.Count() == 3)
            {
                string? tag = rtag.get_Data(1).ToString();
                return new Tag(tag);
            }
            else if (rtag.Count() == 5)
            {
                string? tag = rtag.get_Data(3).ToString();
                if (tag == null) return null;                    //log error

                string? fname = rtag.get_Data(1).ToString();
                if (fname == null) return null;                  //log error


                return new Tag(tag, fname);
            }
            else return null;                                    //log error
        }
        string GetRuleName(Reduction r)
        {
            string ruleName = r.Parent.Head().Name();
            return ruleName;
        }
        List<Reduction>? UnwindItemlist(Reduction r)
        {
            Reduction left = (Reduction)r.get_Data(0);
            Reduction right = (Reduction)r.get_Data(2);

            if (GetRuleName(right) == "item")
            {
                return new List<Reduction>() { left, right };
            }
            else if (GetRuleName(right) == "itemlist")
            {
                List<Reduction>? li = UnwindItemlist(right);
                if (li == null) return null;

                List<Reduction> output = new List<Reduction>() { left };
                foreach (Reduction e in li) output.Add(e);
                return output;
            }

            return null;
        }
    }
    public class Tag
    {
        string _id;
        string? _fileId;

        public string Id
        {
            get { return _id; }
        }
        public string? FileId
        {
            get { return _fileId; }
        }

        public Tag(string id)
        {
            _id = id;
        }
        public Tag(string id, string fileId)
        {
            _id = id;
            _fileId = fileId;
        }
    }
    public class Item
    {
        string _literal;
        Tag _tag;

        public string Literal
        {
            get { return _literal; }
        }
        public Tag Tag
        {
            get { return _tag; }
        }

        public Item(string literal, Tag tag)
        {
            _literal = literal;
            _tag = tag;
        }
    }
}

//https://www.meziantou.net/introduction-to-goldparser.htm
//TestGadget.LoadGrammer(@"C:\PATH HERE\#DESCRIBE.egt");
//TestGadget.ParseTextFiles(@"C:\PATH HERE\", "0_root");
//TestGadget.WriteTree(MainTreeView);


// When there is a literal that is 8 symbols long it is mistaken for an id, resulting in a syntax error
// Cyrilic symbols result in a lexical error
```

### TestGadget v6

```
using GOLD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGadget
{
    public static class TestGadget
    {
        static TestGadget()
        {
            MyParser = new DescribeParser();
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
        }
        public static void Reset()
        {
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
            MyParser.PrimaryProductions = new Dictionary<string, List<string>>();
            MyParser.IsFirstScripture = true;
        }


        public static void WriteTree(TreeView tree)
        {
            tree.Nodes.Clear();

            foreach (string pkey in MyParser.PrimaryProductions.Keys)
            {
                string text = MyParser.Translations[pkey];
                var node = tree.Nodes.Add(text);
                foreach(string lkey in MyParser.PrimaryProductions[pkey])
                {
                    AddLayer(node, lkey);
                }
            }
        }
        static void AddLayer(TreeNode node, string key)
        {
            if (MyParser.Translations.ContainsKey(key) == false) return;

            string text = MyParser.Translations[key];
            var n = node.Nodes.Add(text);

            if(MyParser.Productions.ContainsKey(key))
            {
                foreach (string rkey in MyParser.Productions[key])
                {
                    AddLayer(n, rkey);
                }
            }
            else if (MyParser.PrimaryProductions.ContainsKey(key))
            {
                foreach (string rkey in MyParser.PrimaryProductions[key])
                {
                    AddLayer(n, rkey);
                }
            }
        }


        public static string? SourcePath;
        public static string? GrammarPath;
        public static void LoadGrammer(string path)
        {
            try
            {
                if (MyParser.Setup(path))
                {
                    GrammarPath = path;
                    //MessageBox.Show("CGT loaded");
                }
                else
                {
                    MessageBox.Show("CGT failed to load");
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ParseTextFile(string filename)
        {
            if (MyParser.Loaded == false) return;
            string filetext = ReadTextFile(filename);
            if (filetext == null || string.IsNullOrWhiteSpace(filetext)) return;

            SourcePath = filename;
            ParseSource(filename);
        }
        public static void ParseTextFiles(string path)
        {
            if (MyParser.Loaded == false) return;
            string fname = Path.GetFileName(path);
            string? folder = Path.GetDirectoryName(path);
            if(folder == null) return;
            folder += "\\";

            ParseTextFiles(folder, fname);
        }
        public static void ParseTextFiles(string path, string filename)
        {
            if (MyParser.Loaded == false) return;
            SourcePath = path + filename;

            List<string> parsedFiles = new List<string>();

            string cur = path + filename;
            while (cur != "")
            {
                parsedFiles.Add(cur);

                string filetext = ReadTextFile(cur);
                if (filetext != null 
                    && string.IsNullOrWhiteSpace(filetext) == false)
                {
                    ParseSource(cur);
                }

                cur = "";
                foreach (string s in MyParser.Files.Values)
                {
                    if (parsedFiles.Contains(path + s) == false)
                    {
                        cur = path + s;
                        break;
                    }
                }
            }
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }



        static DescribeParser MyParser;
        static void ParseSource(string path)
        {
            try
            {
                string text = File.ReadAllText(path);
                StringReader reader = new StringReader(text);
                bool result = MyParser.Parse(reader);
                if (result)
                {
                    //MessageBox.Show(path + " parsed successfully!");
                }
                else
                {
                    MessageBox.Show(path + Environment.NewLine + MyParser.FailMessage);
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    internal class DescribeParser
    {
        // The final translations are stored here
        //public List<Production> All = new List<Production>();
        public Dictionary<string, List<string>> PrimaryProductions = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> Productions = new Dictionary<string, List<string>>();
        public Dictionary<string, string> Translations = new Dictionary<string, string>();
        public Dictionary<string, string> Files = new Dictionary<string, string>();

        // Other variables
        public bool Loaded = false;
        private GOLD.Parser parser = new GOLD.Parser();
        public GOLD.Reduction? Root = null;//hacked to be nullable, it wasn't
        public string FailMessage = "";

        public bool Setup(string FilePath)
        {
            Loaded = parser.LoadTables(FilePath);
            return Loaded;
        }
        public bool Parse(TextReader reader)
        {
            GOLD.ParseMessage response;
            bool done = false;
            bool accepted = false;

            parser.Open(reader);
            parser.TrimReductions = false;

            while (!done)
            {
                response = parser.Parse();
                switch (response)
                {
                    case GOLD.ParseMessage.LexicalError:
                        //Cannot recognize token
                        FailMessage = "Lexical Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data;
                        done = true;
                        break;

                    case GOLD.ParseMessage.SyntaxError:
                        //Expecting a different token
                        FailMessage = "Syntax Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data + "\n" +
                                      "Expecting: " + parser.ExpectedSymbols().Text();
                        done = true;
                        break;

                    case GOLD.ParseMessage.Reduction:
                        //Populate dictionaries
                        Populate(parser.CurrentReduction);
                        break;

                    case GOLD.ParseMessage.Accept:
                        //Accepted!
                        Root = (GOLD.Reduction)parser.CurrentReduction;    //The root node!                                  
                        done = true;
                        accepted = true;
                        break;

                    case GOLD.ParseMessage.TokenRead:
                        //You don't have to do anything here.
                        break;

                    case GOLD.ParseMessage.InternalError:
                        //INTERNAL ERROR! Something is horribly wrong.
                        FailMessage = "INTERNAL ERROR! Something is horribly wrong";
                        done = true;
                        break;

                    case GOLD.ParseMessage.NotLoadedError:
                        //This error occurs if the CGT was not loaded.                   
                        FailMessage = "Tables not loaded";
                        done = true;
                        break;

                    case GOLD.ParseMessage.GroupError:
                        //GROUP ERROR! Unexpected end of file
                        FailMessage = "Runaway group";
                        done = true;
                        break;
                }
            }
            return accepted;
        }

        private void Populate(object o)
        {
            Reduction r = (Reduction)o;
            string ruleName = GetRuleName(r);
            if (ruleName != "scripture") return;

            //All = DoScripture(r);
            List<Production> ps = DoScripture(r);
            Translate(ps);
        }
        private void Translate(List<Production> productions)
        {
            foreach (Production p in productions)
            {
                string a = p.Left.Tag.Id;
                if (p.Left.Tag.Type == TagType.File)
                {
                    FileTag ftag = (FileTag)p.Left.Tag;
                    Files.Add(ftag.Id, ftag.FileName);
                }

                List<string> bs = new List<string>();
                foreach (Termin t in p.Rights)
                {
                    bs.Add(t.Tag.Id);
                    if (t.Tag.Type == TagType.File)
                    {
                        FileTag ftag = (FileTag)t.Tag;
                        Files.Add(ftag.Id, ftag.FileName);
                    }
                }

                if(p.IsPrimery) PrimaryProductions.Add(a, bs);
                else Productions.Add(a, bs);


                if (Translations.ContainsKey(p.Left.Tag.Id) == false)
                {
                    Translations.Add(p.Left.Tag.Id, p.Left.Literal);
                }
                foreach (Termin t in p.Rights)
                {
                    if (Translations.ContainsKey(t.Tag.Id) == false)
                    {
                        Translations.Add(t.Tag.Id, t.Literal);
                    }
                }
            }
        }



        //Misc
        string GetRuleName(Reduction r)
        {
            string ruleName = r.Parent.Head().Name();
            return ruleName;
        }

        //Text
        string DoText(Reduction r)
        {
            if(r.Count() == 1)
            {
                string? s = r[0].Data.ToString();
                if (string.IsNullOrEmpty(s))
                {
                    throw new Exception("Inproper TEXT - text[0] is null or empty");
                }
                return s;
            }
            else if (r.Count() == 2)
            {
                string s = DoText((Reduction)r[0].Data) + " " + DoText((Reduction)r[1].Data);
                return s;
            }
            else
            {
                throw new Exception("Inproper TEXT - text is of inproper lenght");
            }
        }

        //Tags
        Tag DoTag(Reduction r)
        {
            if (r.Count() == 3)
            {
                return DoSimpleTag(r);
            }
            else if (r.Count() == 5)
            {
                return DoFileTag(r);
            }
            else
            {
                throw new Exception("Inproper TAG - tag is not 3 or 5 items long");
            }
        }
        SimpleTag DoSimpleTag(Reduction r)
        {
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[1] is not a reduction");
            }
            Reduction rtext = (Reduction)r[1].Data;
            string? rn = GetRuleName(rtext);
            if (rn != "text")
            {
                throw new Exception("Inproper TAG - tag[1] is not \"text\"");
            }
            string tag = DoText(rtext);
            return new SimpleTag(tag);
        }
        FileTag DoFileTag(Reduction r)
        {
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[1] is not a reduction");
            }
            Reduction rtext = (Reduction)r[1].Data;
            string? rn = GetRuleName(rtext);
            if (rn != "text")
            {
                throw new Exception("Inproper TAG - tag[1] is not \"text\"");
            }
            string file = DoText(rtext);

            if (r[3].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[3] is not a reduction");
            }
            Reduction rftext = (Reduction)r[3].Data;
            string? rfn = GetRuleName(rftext);
            if (rfn != "text")
            {
                throw new Exception("Inproper TAG - tag[3] is not \"text\"");
            }
            string tag = DoText(rftext);
            return new FileTag(tag, file);
        }

        //Items
        Termin DoTermin(Reduction r)
        {
            var count = r.Count();

            var data = r[0].Data;
            var data2 = r[1].Data;

            if (count < 1 || count > 3)
            {
                throw new Exception("Inproper ITEM - item must have 1, 2 or 3 items");
            }
            else if (count == 1)
            {
                return DoTermin1(r);
            }
            else if (count == 2)
            {
                return DoTermin2(r);
            }
            else //count == 3
            {
                return DoTermin3(r);
            }
        }
        Termin DoTermin1(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[0] must be a reduction");
            }
            string n = GetRuleName((Reduction)r[0].Data);
            if (n != "tag")
            {
                throw new Exception("Inproper ITEM - item[0] must be a tag");
            }
            //Tag tag = DoTag((Reduction)r[1].Data);
            throw new Exception("Inproper ITEM - item must have 2 items");
        }
        Termin DoTermin2(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[0] must be a reduction");
            }
            string n0 = GetRuleName((Reduction)r[0].Data);
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[1] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[1].Data);

            if (n0 != "text")
            {
                throw new Exception("Inproper ITEM - item[0] must be a text");
            }
            if (n1 != "tag")
            {
                throw new Exception("Inproper ITEM - item[1] must be a tag");
            }

            string text = DoText((Reduction)r[0].Data);
            Tag tag = DoTag((Reduction)r[1].Data);
            return new Termin(text, tag);
        }
        Termin DoTermin3(Reduction r)
        {
            throw new Exception("Inproper ITEM - item must have 1, 2 items");
        }

        //Itemlists
        List<Termin> DoItemlist(Reduction r)
        {
            var count = r.Count();
            if (count != 3)
            {
                throw new Exception("Inproper ITEMLIST - itemlist must have 3 items");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEMLIST - itemlist[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "item")
            {
                throw new Exception("Inproper ITEMLIST - itemlist[0] must be an item");
            }

            if (r[2].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEMLIST - itemlist[2] must be a reduction");
            }
            string n2 = GetRuleName((Reduction)r[2].Data);
            if (n2 != "item" && n2 != "itemlist")
            {
                throw new Exception("Inproper ITEMLIST - itemlist[2] must be an item or an itemlist");
            }

            Termin a = DoTermin((Reduction)r[0].Data);
            List<Termin> list = new List<Termin>() { a };

            if(n2 == "item")
            {
                Termin b = DoTermin((Reduction)r[2].Data);
                list.Add(b);
            }
            else
            {
                List<Termin> bs = DoItemlist((Reduction)r[2].Data);
                foreach (Termin t in bs) list.Add(t);
            }

            return list;
        }

        //Expressions
        Production DoExpression(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSION - expression[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "item")
            {
                throw new Exception("Inproper EXPRESSION - expression[0] must be an item");
            }
            Termin leftHandSide = DoTermin((Reduction)r[0].Data);

            if (r[1].Data.ToString() != "->")
            {
                throw new Exception("Inproper EXPRESSION - expression[1] must be '->'");
            }

            List<Termin> ts = new List<Termin>();
            for (int i = 2; i < r.Count(); i++)
            {
                if (r[i].Data is Reduction)
                {
                    string ruleName = GetRuleName((Reduction)r[i].Data);

                    switch (ruleName)
                    {
                        case "item":
                            Termin x = DoTermin((Reduction)r[i].Data);
                            ts.Add(x);
                            break;
                        case "itemlist":
                            List<Termin> ys = DoItemlist((Reduction)r[i].Data);
                            foreach (Termin y in ys) ts.Add(y);
                            break;
                        case "expression":
                            Termin z = DoExpression((Reduction)r[i].Data).Left;
                            ts.Add(z);
                            break;
                        case "expressionlist":
                            List<Production> ms = DoExpressionlist((Reduction)r[i].Data);
                            foreach (Production m in ms) ts.Add(m.Left);
                            break;
                        default:
                            continue;
                    }
                }
            }

            return new Production(leftHandSide, ts);
        }
        List<Production> DoExpressionlist(Reduction r)
        {
            var count = r.Count();
            if (count != 2)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist must have 2 items");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "expression")
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[0] must be an expression");
            }

            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[1] must be a reduction");
            }
            string n2 = GetRuleName((Reduction)r[1].Data);
            if (n2 != "expression" && n2 != "expressionlist")
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[1] must be an expression or an expressionlist");
            }

            Production a = DoExpression((Reduction)r[0].Data);
            List<Production> list = new List<Production>() { a };

            if (n2 == "expression")
            {
                Production b = DoExpression((Reduction)r[1].Data);
                list.Add(b);
            }
            else
            {
                List<Production> bs = DoExpressionlist((Reduction)r[1].Data);
                foreach (Production t in bs) list.Add(t);
            }

            return list;
        }

        //Scripture
        public bool IsFirstScripture = true;
        List<Production> DoScripture(Reduction r)
        {
            var count = r.Count();
            if (count != 1)
            {
                throw new Exception("Inproper SCRIPTURE - scripture must have 1 item");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper SCRIPTURE - scripture[0] must be a reduction");
            }
            string n = GetRuleName((Reduction)r[0].Data);
            if (n != "expression" && n != "expressionlist")
            {
                throw new Exception("Inproper SCRIPTURE - scripture[0] must be an expression or an expressionlist");
            }

            if(n == "expression")
            {
                Production p = DoExpression((Reduction)r[0].Data);
                if (IsFirstScripture)
                {
                    p.IsPrimery = true;
                    IsFirstScripture = false;
                }
                return new List<Production>() { p };
            }
            else
            {
                List<Production> ps = DoExpressionlist((Reduction)r[0].Data);
                if (IsFirstScripture)
                {
                    foreach (Production p in ps) p.IsPrimery = true;
                    IsFirstScripture = false;
                }
                return ps;
            }
        }
    }




}

//https://www.meziantou.net/introduction-to-goldparser.htm
//TestGadget.LoadGrammer(@"C:\PATH HERE\#DESCRIBE.egt");
//TestGadget.ParseTextFiles(@"C:\PATH HERE\", "0_root");
//TestGadget.WriteTree(MainTreeView);
```


### TestGadget v6.1

```
using GOLD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGadget
{
    public static class TestGadget
    {
        static TestGadget()
        {
            MyParser = new DescribeParser();
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
            NodeDict = new Dictionary<TreeNode, string>();
        }
        public static void Reset()
        {
            MyParser.Translations = new Dictionary<string, string>();
            MyParser.Files = new Dictionary<string, string>();
            MyParser.Productions = new Dictionary<string, List<string>>();
            MyParser.PrimaryProductions = new Dictionary<string, List<string>>();
            MyParser.IsFirstScripture = true;
        }


        public static Dictionary<TreeNode, string> NodeDict;
        public static void WriteTree(TreeView tree)
        {
            tree.Nodes.Clear();
            NodeDict = new Dictionary<TreeNode, string>();

            foreach (string pkey in MyParser.PrimaryProductions.Keys)
            {
                string text = MyParser.Translations[pkey];
                var node = tree.Nodes.Add(text);
                if (!NodeDict.ContainsKey(node)) NodeDict.Add(node, pkey);
                else
                {
                    var lll = NodeDict[node];
                }
                foreach(string lkey in MyParser.PrimaryProductions[pkey])
                {
                    AddLayer(node, lkey);
                }
            }
        }
        static void AddLayer(TreeNode node, string key)
        {
            if (MyParser.Translations.ContainsKey(key) == false) return;

            string text = MyParser.Translations[key];
            var n = node.Nodes.Add(text);
            if(!NodeDict.ContainsKey(n)) NodeDict.Add(n, key);
            else
            {
                var lll = NodeDict[n];
            }
            if (MyParser.Productions.ContainsKey(key))
            {
                foreach (string rkey in MyParser.Productions[key])
                {
                    AddLayer(n, rkey);
                }
            }
            else if (MyParser.PrimaryProductions.ContainsKey(key))
            {
                foreach (string rkey in MyParser.PrimaryProductions[key])
                {
                    AddLayer(n, rkey);
                }
            }
        }


        public static string? SourcePath;
        public static string? GrammarPath;
        public static void LoadGrammer(string path)
        {
            try
            {
                if (MyParser.Setup(path))
                {
                    GrammarPath = path;
                    //MessageBox.Show("CGT loaded");
                }
                else
                {
                    MessageBox.Show("CGT failed to load");
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ParseTextFile(string filename)
        {
            if (MyParser.Loaded == false) return;
            string filetext = ReadTextFile(filename);
            if (filetext == null || string.IsNullOrWhiteSpace(filetext)) return;

            SourcePath = filename;
            MyParser.CurrentSourcePath = filename;
            ParseSource(filename);
        }
        public static void ParseTextFiles(string path)
        {
            if (MyParser.Loaded == false) return;
            string fname = Path.GetFileName(path);
            string? folder = Path.GetDirectoryName(path);
            if(folder == null) return;
            folder += "\\";

            ParseTextFiles(folder, fname);
        }
        public static void ParseTextFiles(string path, string filename)
        {
            if (MyParser.Loaded == false) return;
            SourcePath = path + filename;

            List<string> parsedFiles = new List<string>();

            MyParser.CurrentSourcePath = path + filename;
            while (MyParser.CurrentSourcePath != "")
            {
                parsedFiles.Add(MyParser.CurrentSourcePath);

                string filetext = ReadTextFile(MyParser.CurrentSourcePath);
                if (filetext != null 
                    && string.IsNullOrWhiteSpace(filetext) == false)
                {
                    ParseSource(MyParser.CurrentSourcePath);
                }

                MyParser.CurrentSourcePath = "";
                foreach (string s in MyParser.Files.Values)
                {
                    if (parsedFiles.Contains(s) == false)
                    {
                        MyParser.CurrentSourcePath = s;
                        break;
                    }
                }
            }
        }
        static string ReadTextFile(string filename)
        {
            try
            {
                string text = File.ReadAllText(filename);
                return text;
            }
            catch
            {
                return null;
            }
        }



        internal static DescribeParser MyParser;
        static void ParseSource(string path)
        {
            try
            {
                string text = File.ReadAllText(path);
                StringReader reader = new StringReader(text);
                bool result = MyParser.Parse(reader);
                if (result)
                {
                    //MessageBox.Show(path + " parsed successfully!");
                }
                else
                {
                    MessageBox.Show(path + Environment.NewLine + MyParser.FailMessage);
                }
            }
            catch (GOLD.ParserException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    internal class DescribeParser
    {
        // The final translations are stored here
        //public List<Production> All = new List<Production>();
        public Dictionary<string, List<string>> PrimaryProductions = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> Productions = new Dictionary<string, List<string>>();
        public Dictionary<string, string> Translations = new Dictionary<string, string>();
        public Dictionary<string, string> Files = new Dictionary<string, string>();

        // Other variables
        public bool Loaded = false;
        private GOLD.Parser parser = new GOLD.Parser();
        public GOLD.Reduction? Root = null;//hacked to be nullable, it wasn't
        public string FailMessage = "";

        public bool Setup(string FilePath)
        {
            Loaded = parser.LoadTables(FilePath);
            return Loaded;
        }
        public bool Parse(TextReader reader)
        {
            GOLD.ParseMessage response;
            bool done = false;
            bool accepted = false;

            parser.Open(reader);
            parser.TrimReductions = false;

            while (!done)
            {
                response = parser.Parse();
                switch (response)
                {
                    case GOLD.ParseMessage.LexicalError:
                        //Cannot recognize token
                        FailMessage = "Lexical Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data;
                        done = true;
                        break;

                    case GOLD.ParseMessage.SyntaxError:
                        //Expecting a different token
                        FailMessage = "Syntax Error:\n" +
                                      "Position: " + parser.CurrentPosition().Line + ", " + parser.CurrentPosition().Column + "\n" +
                                      "Read: " + parser.CurrentToken().Data + "\n" +
                                      "Expecting: " + parser.ExpectedSymbols().Text();
                        done = true;
                        break;

                    case GOLD.ParseMessage.Reduction:
                        //Populate dictionaries
                        Populate(parser.CurrentReduction);
                        break;

                    case GOLD.ParseMessage.Accept:
                        //Accepted!
                        Root = (GOLD.Reduction)parser.CurrentReduction;    //The root node!                                  
                        done = true;
                        accepted = true;
                        break;

                    case GOLD.ParseMessage.TokenRead:
                        //You don't have to do anything here.
                        break;

                    case GOLD.ParseMessage.InternalError:
                        //INTERNAL ERROR! Something is horribly wrong.
                        FailMessage = "INTERNAL ERROR! Something is horribly wrong";
                        done = true;
                        break;

                    case GOLD.ParseMessage.NotLoadedError:
                        //This error occurs if the CGT was not loaded.                   
                        FailMessage = "Tables not loaded";
                        done = true;
                        break;

                    case GOLD.ParseMessage.GroupError:
                        //GROUP ERROR! Unexpected end of file
                        FailMessage = "Runaway group";
                        done = true;
                        break;
                }
            }
            return accepted;
        }

        private void Populate(object o)
        {
            Reduction r = (Reduction)o;
            string ruleName = GetRuleName(r);
            if (ruleName != "scripture") return;

            //All = DoScripture(r);
            List<Production> ps = DoScripture(r);
            Translate(ps);
        }
        private void Translate(List<Production> productions)
        {
            foreach (Production p in productions)
            {
                string a = p.Left.Tag.Id;
                if (p.Left.Tag.Type == TagType.File)
                {
                    FileTag ftag = (FileTag)p.Left.Tag;
                    //Files.Add(ftag.Id, ftag.FileName);
                }

                List<string> bs = new List<string>();
                foreach (Termin t in p.Rights)
                {
                    bs.Add(t.Tag.Id);
                    if (t.Tag.Type == TagType.File)
                    {
                        FileTag ftag = (FileTag)t.Tag;
                        //Files.Add(ftag.Id, ftag.FileName);
                    }
                }

                if(p.IsPrimery) PrimaryProductions.Add(a, bs);
                else Productions.Add(a, bs);


                if (Translations.ContainsKey(p.Left.Tag.Id) == false)
                {
                    Translations.Add(p.Left.Tag.Id, p.Left.Literal);
                }
                foreach (Termin t in p.Rights)
                {
                    if (Translations.ContainsKey(t.Tag.Id) == false)
                    {
                        Translations.Add(t.Tag.Id, t.Literal);
                    }
                }
            }
        }



        //Misc
        internal string? CurrentSourcePath;
        string GetRuleName(Reduction r)
        {
            string ruleName = r.Parent.Head().Name();
            return ruleName;
        }

        //Text
        string DoText(Reduction r)
        {
            if(r.Count() == 1)
            {
                string? s = r[0].Data.ToString();
                if (string.IsNullOrEmpty(s))
                {
                    throw new Exception("Inproper TEXT - text[0] is null or empty");
                }
                return s;
            }
            else if (r.Count() == 2)
            {
                string s = DoText((Reduction)r[0].Data) + " " + DoText((Reduction)r[1].Data);
                return s;
            }
            else
            {
                throw new Exception("Inproper TEXT - text is of inproper lenght");
            }
        }

        //Tags
        Tag DoTag(Reduction r)
        {
            if (r.Count() == 3)
            {
                return DoSimpleTag(r);
            }
            else if (r.Count() == 5)
            {
                return DoFileTag(r);
            }
            else
            {
                throw new Exception("Inproper TAG - tag is not 3 or 5 items long");
            }
        }
        SimpleTag DoSimpleTag(Reduction r)
        {
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[1] is not a reduction");
            }
            Reduction rtext = (Reduction)r[1].Data;
            string? rn = GetRuleName(rtext);
            if (rn != "text")
            {
                throw new Exception("Inproper TAG - tag[1] is not \"text\"");
            }
            string tag = DoText(rtext);
            if(CurrentSourcePath != null && 
                !Files.ContainsKey(tag)) 
                    Files.Add(tag, CurrentSourcePath);
            return new SimpleTag(tag);
        }
        FileTag DoFileTag(Reduction r)
        {
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[1] is not a reduction");
            }
            Reduction rtext = (Reduction)r[1].Data;
            string? rn = GetRuleName(rtext);
            if (rn != "text")
            {
                throw new Exception("Inproper TAG - tag[1] is not \"text\"");
            }
            string file = DoText(rtext);

            if (r[3].Data is Reduction == false)
            {
                throw new Exception("Inproper TAG - tag[3] is not a reduction");
            }
            Reduction rftext = (Reduction)r[3].Data;
            string? rfn = GetRuleName(rftext);
            if (rfn != "text")
            {
                throw new Exception("Inproper TAG - tag[3] is not \"text\"");
            }
            string tag = DoText(rftext);
            if (CurrentSourcePath != null &&
                !Files.ContainsKey(tag))
                    Files.Add(tag, Path.GetDirectoryName(CurrentSourcePath) + "\\" + file);
            return new FileTag(tag, file);
        }

        //Items
        Termin DoTermin(Reduction r)
        {
            var count = r.Count();

            var data = r[0].Data;
            var data2 = r[1].Data;

            if (count < 1 || count > 3)
            {
                throw new Exception("Inproper ITEM - item must have 1, 2 or 3 items");
            }
            else if (count == 1)
            {
                return DoTermin1(r);
            }
            else if (count == 2)
            {
                return DoTermin2(r);
            }
            else //count == 3
            {
                return DoTermin3(r);
            }
        }
        Termin DoTermin1(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[0] must be a reduction");
            }
            string n = GetRuleName((Reduction)r[0].Data);
            if (n != "tag")
            {
                throw new Exception("Inproper ITEM - item[0] must be a tag");
            }
            //Tag tag = DoTag((Reduction)r[1].Data);
            throw new Exception("Inproper ITEM - item must have 2 items");
        }
        Termin DoTermin2(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[0] must be a reduction");
            }
            string n0 = GetRuleName((Reduction)r[0].Data);
            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEM - item[1] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[1].Data);

            if (n0 != "text")
            {
                throw new Exception("Inproper ITEM - item[0] must be a text");
            }
            if (n1 != "tag")
            {
                throw new Exception("Inproper ITEM - item[1] must be a tag");
            }

            string text = DoText((Reduction)r[0].Data);
            Tag tag = DoTag((Reduction)r[1].Data);
            return new Termin(text, tag);
        }
        Termin DoTermin3(Reduction r)
        {
            throw new Exception("Inproper ITEM - item must have 1, 2 items");
        }

        //Itemlists
        List<Termin> DoItemlist(Reduction r)
        {
            var count = r.Count();
            if (count != 3)
            {
                throw new Exception("Inproper ITEMLIST - itemlist must have 3 items");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEMLIST - itemlist[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "item")
            {
                throw new Exception("Inproper ITEMLIST - itemlist[0] must be an item");
            }

            if (r[2].Data is Reduction == false)
            {
                throw new Exception("Inproper ITEMLIST - itemlist[2] must be a reduction");
            }
            string n2 = GetRuleName((Reduction)r[2].Data);
            if (n2 != "item" && n2 != "itemlist")
            {
                throw new Exception("Inproper ITEMLIST - itemlist[2] must be an item or an itemlist");
            }

            Termin a = DoTermin((Reduction)r[0].Data);
            List<Termin> list = new List<Termin>() { a };

            if(n2 == "item")
            {
                Termin b = DoTermin((Reduction)r[2].Data);
                list.Add(b);
            }
            else
            {
                List<Termin> bs = DoItemlist((Reduction)r[2].Data);
                foreach (Termin t in bs) list.Add(t);
            }

            return list;
        }

        //Expressions
        Production DoExpression(Reduction r)
        {
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSION - expression[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "item")
            {
                throw new Exception("Inproper EXPRESSION - expression[0] must be an item");
            }
            Termin leftHandSide = DoTermin((Reduction)r[0].Data);

            if (r[1].Data.ToString() != "->")
            {
                throw new Exception("Inproper EXPRESSION - expression[1] must be '->'");
            }

            List<Termin> ts = new List<Termin>();
            for (int i = 2; i < r.Count(); i++)
            {
                if (r[i].Data is Reduction)
                {
                    string ruleName = GetRuleName((Reduction)r[i].Data);

                    switch (ruleName)
                    {
                        case "item":
                            Termin x = DoTermin((Reduction)r[i].Data);
                            ts.Add(x);
                            break;
                        case "itemlist":
                            List<Termin> ys = DoItemlist((Reduction)r[i].Data);
                            foreach (Termin y in ys) ts.Add(y);
                            break;
                        case "expression":
                            Termin z = DoExpression((Reduction)r[i].Data).Left;
                            ts.Add(z);
                            break;
                        case "expressionlist":
                            List<Production> ms = DoExpressionlist((Reduction)r[i].Data);
                            foreach (Production m in ms) ts.Add(m.Left);
                            break;
                        default:
                            continue;
                    }
                }
            }

            return new Production(leftHandSide, ts);
        }
        List<Production> DoExpressionlist(Reduction r)
        {
            var count = r.Count();
            if (count != 2)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist must have 2 items");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[0] must be a reduction");
            }
            string n1 = GetRuleName((Reduction)r[0].Data);
            if (n1 != "expression")
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[0] must be an expression");
            }

            if (r[1].Data is Reduction == false)
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[1] must be a reduction");
            }
            string n2 = GetRuleName((Reduction)r[1].Data);
            if (n2 != "expression" && n2 != "expressionlist")
            {
                throw new Exception("Inproper EXPRESSIONLIST - expressionlist[1] must be an expression or an expressionlist");
            }

            Production a = DoExpression((Reduction)r[0].Data);
            List<Production> list = new List<Production>() { a };

            if (n2 == "expression")
            {
                Production b = DoExpression((Reduction)r[1].Data);
                list.Add(b);
            }
            else
            {
                List<Production> bs = DoExpressionlist((Reduction)r[1].Data);
                foreach (Production t in bs) list.Add(t);
            }

            return list;
        }

        //Scripture
        public bool IsFirstScripture = true;
        List<Production> DoScripture(Reduction r)
        {
            var count = r.Count();
            if (count != 1)
            {
                throw new Exception("Inproper SCRIPTURE - scripture must have 1 item");
            }
            if (r[0].Data is Reduction == false)
            {
                throw new Exception("Inproper SCRIPTURE - scripture[0] must be a reduction");
            }
            string n = GetRuleName((Reduction)r[0].Data);
            if (n != "expression" && n != "expressionlist")
            {
                throw new Exception("Inproper SCRIPTURE - scripture[0] must be an expression or an expressionlist");
            }

            if(n == "expression")
            {
                Production p = DoExpression((Reduction)r[0].Data);
                if (IsFirstScripture)
                {
                    p.IsPrimery = true;
                    IsFirstScripture = false;
                }
                return new List<Production>() { p };
            }
            else
            {
                List<Production> ps = DoExpressionlist((Reduction)r[0].Data);
                if (IsFirstScripture)
                {
                    foreach (Production p in ps) p.IsPrimery = true;
                    IsFirstScripture = false;
                }
                return ps;
            }
        }
    }




}

//https://www.meziantou.net/introduction-to-goldparser.htm
//TestGadget.LoadGrammer(@"C:\PATH HERE\#DESCRIBE.egt");
//TestGadget.ParseTextFiles(@"C:\PATH HERE\", "0_root");
//TestGadget.WriteTree(MainTreeView);
```

