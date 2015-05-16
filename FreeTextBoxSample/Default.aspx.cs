using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreeTextBoxControls;

namespace FreeTextBoxSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FreeTextBox1.Toolbars.Clear();

                Toolbar tbStandard = new Toolbar();

                Save btnSave                           = new Save();
                Print btnPrint                         = new Print();
                Preview btnPreview                     = new Preview();
                SelectAll btnSelectAll                 = new SelectAll();
                Cut btnCut                             = new Cut();
                Copy btnCopy                           = new Copy();
                Paste btnPaste                         = new Paste();
                Delete btnDelete                       = new Delete();
                Undo btnUndo                           = new Undo();
                Redo btnRedo                           = new Redo();
                CreateLink btnCreateLink               = new CreateLink();
                Unlink btnUnlink                       = new Unlink();
                InsertImage btnInsertImage             = new InsertImage();
                InsertImageFromGallery btnImageGallery = new InsertImageFromGallery();
                IeSpellCheck btnIeSpellCheck = new IeSpellCheck();
                NetSpell btnNetSpell = new NetSpell();
                WordClean btnWordClean = new WordClean();


                //tbStandard.Items.Add(btnSave);
                tbStandard.Items.Add(btnPrint);
                tbStandard.Items.Add(btnPreview);
                tbStandard.Items.Add(new ToolbarSeparator());
                tbStandard.Items.Add(btnSelectAll);
                tbStandard.Items.Add(btnCut);
                tbStandard.Items.Add(btnCopy);
                tbStandard.Items.Add(btnPaste);
                tbStandard.Items.Add(btnDelete);
                tbStandard.Items.Add(new ToolbarSeparator());
                tbStandard.Items.Add(btnUndo);
                tbStandard.Items.Add(btnRedo);
                tbStandard.Items.Add(new ToolbarSeparator());
                tbStandard.Items.Add(btnCreateLink);
                tbStandard.Items.Add(btnUnlink);
                tbStandard.Items.Add(new ToolbarSeparator());
                tbStandard.Items.Add(btnInsertImage);
                tbStandard.Items.Add(btnImageGallery);
                tbStandard.Items.Add(new ToolbarSeparator());
                tbStandard.Items.Add(btnIeSpellCheck);
                tbStandard.Items.Add(btnNetSpell);
                tbStandard.Items.Add(btnWordClean);

                FreeTextBox1.Toolbars.Add(tbStandard);

                Toolbar tbFormatting = new Toolbar();

                ParagraphMenu ddlParagraph = new ParagraphMenu();

                FontFacesMenu ddlFontFaces = new FontFacesMenu();

                ToolbarListItem JhengHei   = new ToolbarListItem("微軟正黑體", "Microsoft JhengHei");
                ToolbarListItem Kai        = new ToolbarListItem("標楷體", "DFKai-sb");
                ToolbarListItem PMingLiU   = new ToolbarListItem("新細明體", "PMingLiU");
                ToolbarListItem MingLiU    = new ToolbarListItem("細明體", "MingLiU");
                ToolbarListItem serif      = new ToolbarListItem("Serif", "serif");
                ToolbarListItem sans       = new ToolbarListItem("Sans-serif", "sans-serif");

                ToolbarListItem CourierNew = new ToolbarListItem("CourierNew", "Courier New");
                ToolbarListItem Garamond   = new ToolbarListItem("Garamond", "Garamond");
                ToolbarListItem Georgia    = new ToolbarListItem("Georgia", "Georgia");
                ToolbarListItem Tahoma     = new ToolbarListItem("Tahoma", "Tahoma");
                ToolbarListItem Times      = new ToolbarListItem("Times", "Times New Roman");
                ToolbarListItem Verdana    = new ToolbarListItem("Verdana", "Verdana");

                ddlFontFaces.Items.Add(JhengHei);
                ddlFontFaces.Items.Add(Kai);
                ddlFontFaces.Items.Add(PMingLiU);
                ddlFontFaces.Items.Add(MingLiU);
                ddlFontFaces.Items.Add(serif);
                ddlFontFaces.Items.Add(sans);
                ddlFontFaces.Items.Add(CourierNew);
                ddlFontFaces.Items.Add(Garamond);
                ddlFontFaces.Items.Add(Georgia);
                ddlFontFaces.Items.Add(Tahoma);
                ddlFontFaces.Items.Add(Times);
                ddlFontFaces.Items.Add(Verdana);

                FontSizesMenu ddlFontSizes = new FontSizesMenu();

                Bold btnBold                                     = new Bold();
                Italic btnItalic                                 = new Italic();
                Underline btnUnderline                           = new Underline();
                StrikeThrough btnStrikeThrough                   = new StrikeThrough();
                SuperScript btnSuperScript                       = new SuperScript();
                SubScript btnSubScript                           = new SubScript();
                JustifyFull btnJustifyFull                       = new JustifyFull();
                JustifyLeft btnJustifyLeft                       = new JustifyLeft();
                JustifyRight btnJustifyRight                     = new JustifyRight();
                JustifyCenter btnJustifyCenter                   = new JustifyCenter();
                NumberedList btnNumberedList                     = new NumberedList();
                FreeTextBoxControls.BulletedList btnBulletedList = new FreeTextBoxControls.BulletedList();
                Indent  btnIndent                                = new Indent ();
                Outdent btnOutdent                               = new Outdent();
                FontForeColorPicker btnFontForeColorPicker       = new FontForeColorPicker();
                FontBackColorPicker btnFontBackColorPicker       = new FontBackColorPicker();
                RemoveFormat btnRemoveFormat                     = new RemoveFormat();
                EditStyle btnEditStyle                           = new EditStyle();

                tbFormatting.Items.Add(ddlParagraph);
                tbFormatting.Items.Add(ddlFontFaces);
                tbFormatting.Items.Add(ddlFontSizes);
                tbFormatting.Items.Add(new ToolbarSeparator());
                tbFormatting.Items.Add(btnBold);
                tbFormatting.Items.Add(btnItalic);
                tbFormatting.Items.Add(btnUnderline);
                tbFormatting.Items.Add(btnStrikeThrough);
                tbFormatting.Items.Add(btnSuperScript);
                tbFormatting.Items.Add(btnSubScript);
                tbFormatting.Items.Add(new ToolbarSeparator());
                tbFormatting.Items.Add(btnJustifyFull);
                tbFormatting.Items.Add(btnJustifyLeft);
                tbFormatting.Items.Add(btnJustifyRight);
                tbFormatting.Items.Add(btnJustifyCenter);
                tbFormatting.Items.Add(new ToolbarSeparator());
                tbFormatting.Items.Add(btnNumberedList);
                tbFormatting.Items.Add(btnBulletedList);
                tbFormatting.Items.Add(btnIndent);
                tbFormatting.Items.Add(btnOutdent);
                tbFormatting.Items.Add(new ToolbarSeparator());
                tbFormatting.Items.Add(btnFontForeColorPicker);
                tbFormatting.Items.Add(btnFontBackColorPicker);
                tbFormatting.Items.Add(new ToolbarSeparator());
                tbFormatting.Items.Add(btnRemoveFormat);
                tbFormatting.Items.Add(btnEditStyle);
                FreeTextBox1.Toolbars.Add(tbFormatting);

                Toolbar tbTables = new Toolbar();

                InsertTable btnInsertTable                         = new InsertTable();
                EditTable btnEditTable                             = new EditTable();
                InsertTableRowAfter btnInsertTableRowAfter         = new InsertTableRowAfter();
                InsertTableRowBefore btnInsertTableRowBefore       = new InsertTableRowBefore();
                DeleteTableRow btnDeleteTableRow                   = new DeleteTableRow();
                InsertTableColumnAfter btnInsertTableColumnAfter   = new InsertTableColumnAfter();
                InsertTableColumnBefore btnInsertTableColumnBefore = new InsertTableColumnBefore();
                DeleteTableColumn btnDeleteTableColumn             = new DeleteTableColumn();

                tbTables.Items.Add(btnInsertTable);
                tbTables.Items.Add(btnEditTable);
                tbTables.Items.Add(new ToolbarSeparator());
                tbTables.Items.Add(btnInsertTableRowAfter);
                tbTables.Items.Add(btnInsertTableRowBefore);
                tbTables.Items.Add(btnDeleteTableRow);
                tbTables.Items.Add(new ToolbarSeparator());
                tbTables.Items.Add(btnInsertTableColumnAfter);
                tbTables.Items.Add(btnInsertTableColumnBefore);
                tbTables.Items.Add(btnDeleteTableColumn);
                FreeTextBox1.Toolbars.Add(tbTables);

                Toolbar tbControlToolbox = new Toolbar();

                InsertDiv btnInsertDiv                   = new InsertDiv();
                InsertForm btnInsertForm                 = new InsertForm();
                InsertCheckBox btnInsertCheckBox         = new InsertCheckBox();
                InsertTextBox btnInsertTextBox           = new InsertTextBox();
                InsertButton btnInsertButton             = new InsertButton();
                InsertRadioButton btnInsertRadioButton   = new InsertRadioButton();
                InsertDropDownList btnInsertDropDownList = new InsertDropDownList();
                InsertTextArea btnInsertTextArea         = new InsertTextArea();

                tbControlToolbox.Items.Add(btnInsertDiv);
                tbControlToolbox.Items.Add(btnInsertForm);
                tbControlToolbox.Items.Add(btnInsertCheckBox);
                tbControlToolbox.Items.Add(btnInsertTextBox);
                tbControlToolbox.Items.Add(btnInsertButton);
                tbControlToolbox.Items.Add(btnInsertRadioButton);
                tbControlToolbox.Items.Add(btnInsertDropDownList);
                tbControlToolbox.Items.Add(btnInsertTextArea);

                FreeTextBox1.Toolbars.Add(tbControlToolbox);

                Toolbar tbInsert = new Toolbar();

                SymbolsMenu ddlSymbols   = new SymbolsMenu();
                InsertRule btnInsertRule = new InsertRule();
                InsertDate btnInsertDate = new InsertDate();
                InsertTime btnInsertTime = new InsertTime();

                tbInsert.Items.Add(ddlSymbols);
                tbInsert.Items.Add(btnInsertRule);
                tbInsert.Items.Add(btnInsertDate);
                tbInsert.Items.Add(btnInsertTime);

                FreeTextBox1.Toolbars.Add(tbInsert);
            }
        }
    }
}