using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using ScintillaNET;

namespace PawnEE
{
    public partial class TextEditor : DockContent
    {
        public TextEditor()
        {
            InitializeComponent();


            scintilla1.TextChanged += (this.OnTextChanged);
            scintilla1.WrapMode = WrapMode.None;
            scintilla1.IndentationGuides = IndentView.LookBoth;

            InitColors();
            InitSyntaxColoring();
            InitNumberMargin();
            InitBookmarkMargin();
            InitCodeFolding();
        }

        private void InitColors()
        {

            scintilla1.SetSelectionBackColor(true, Color.FromArgb(38, 79, 120));

        }

        public string editorText
        {
            get
            {
                return this.scintilla1.Text;
            }
            set
            {
                this.scintilla1.Text = value;
            }
        }

        private const int NUMBER_MARGIN = 2;
        private const int BOOKMARK_MARGIN = 1;
        private const int BOOKMARK_MARKER = 1;
        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;

        private void InitBookmarkMargin()
        {
            var margin = scintilla1.Margins[BOOKMARK_MARGIN];
            margin.Width = 20;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.BackColor = Color.FromArgb(51, 51, 51);
            margin.Mask = (1 << BOOKMARK_MARKER);

            var marker = scintilla1.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(IntToColor(0xFF003B));
            marker.SetForeColor(IntToColor(0xFFFFFF));
            marker.SetAlpha(100);
        }

        private void InitCodeFolding()
        {
            scintilla1.SetFoldMarginColor(true, Color.FromArgb(30, 30, 30));
            scintilla1.SetFoldMarginHighlightColor(true, Color.FromArgb(30, 30, 30));

            scintilla1.SetProperty("fold", "1");
            scintilla1.SetProperty("fold.compact", "1");

            scintilla1.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            scintilla1.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            scintilla1.Margins[FOLDING_MARGIN].Sensitive = true;
            scintilla1.Margins[FOLDING_MARGIN].Width = 20;

            for (int i = 25; i <= 31; i++)
            {
                scintilla1.Markers[i].SetForeColor(Color.FromArgb(30, 30, 30)); // styles for [+] and [-]
                scintilla1.Markers[i].SetBackColor(Color.FromArgb(165, 165, 165)); // styles for [+] and [-]
            }

            scintilla1.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.BoxPlus : MarkerSymbol.CirclePlus;
            scintilla1.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.BoxMinus : MarkerSymbol.CircleMinus;
            scintilla1.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            scintilla1.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla1.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            scintilla1.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla1.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            scintilla1.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
        }


        private void InitNumberMargin()
        {
            scintilla1.Styles[Style.LineNumber].BackColor = Color.FromArgb(30, 30, 30);
            scintilla1.Styles[Style.LineNumber].ForeColor = Color.FromArgb(43, 145, 175);
            scintilla1.Styles[Style.Default].BackColor = Color.FromArgb(30, 30, 30);

            var nums = scintilla1.Margins[NUMBER_MARGIN];
            nums.Width = 40;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            scintilla1.MarginClick += TextArea_MarginClick;
        }

        private void TextArea_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (e.Margin == BOOKMARK_MARGIN)
            {
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = scintilla1.Lines[scintilla1.LineFromPosition(e.Position)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    line.MarkerDelete(BOOKMARK_MARKER);
                }
                else
                {
                    line.MarkerAdd(BOOKMARK_MARKER);
                }
            }
        }

        private void InitSyntaxColoring()
        {

            // Configure the default style
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.Styles[Style.Default].BackColor = Color.FromArgb(30, 30, 30);
            scintilla1.Styles[Style.Default].ForeColor = Color.FromArgb(220, 220, 220);
            scintilla1.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            scintilla1.Styles[Style.Cpp.Identifier].ForeColor = Color.FromArgb(208, 218, 226);
            scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(87, 166, 74);
            scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(87, 166, 74);
            scintilla1.Styles[Style.Cpp.CommentDoc].ForeColor = Color.FromArgb(47, 174, 53);
            scintilla1.Styles[Style.Cpp.Number].ForeColor = Color.FromArgb(181, 206, 168);
            scintilla1.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(214, 157, 133);
            scintilla1.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(233, 84, 84);
            scintilla1.Styles[Style.Cpp.Preprocessor].ForeColor = Color.FromArgb(138, 175, 238);
            scintilla1.Styles[Style.Cpp.Operator].ForeColor = Color.FromArgb(224, 224, 224);
            scintilla1.Styles[Style.Cpp.Regex].ForeColor = Color.FromArgb(255, 0, 255);
            scintilla1.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(119, 167, 219);
            scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.FromArgb(72, 168, 238);
            scintilla1.Styles[Style.Cpp.Word2].ForeColor = Color.FromArgb(78, 201, 176);
            scintilla1.Styles[Style.Cpp.CommentDocKeyword].ForeColor = Color.FromArgb(179, 217, 145);
            scintilla1.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Color.FromArgb(255, 0, 0);
            scintilla1.Styles[Style.Cpp.GlobalClass].ForeColor = Color.FromArgb(72, 168, 238);

            scintilla1.Lexer = Lexer.Cpp;

            scintilla1.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            scintilla1.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");

        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }


    }
}
