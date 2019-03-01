using DBI_Exam_Creator_Tool.Entities;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Utils
{
    static class DocUtils
    {
        /// <summary>
        /// Setting for doc file
        /// </summary>
        /// <param name="document"></param>
        static public void SettingsPage(Document document)
        {
            foreach (Section section in document.Sections)
            {
                section.PageSetup.PaperSize = WdPaperSize.wdPaperA4;
            }

            //1 inch = 72 points

            document.PageSetup.BottomMargin = 72;
            document.PageSetup.TopMargin = 72;
            document.PageSetup.LeftMargin = 72;
            document.PageSetup.RightMargin = 72;

            document.PageSetup.FooterDistance = 36;
            document.PageSetup.HeaderDistance = 36;

            document.PageSetup.Orientation = WdOrientation.wdOrientPortrait;

        }
        
        /// <summary>
        /// Setting header and footer 
        /// </summary>
        /// <param name="examItem"></param>
        /// <param name="section"></param>
        /// <param name="isTest">For adding Paper No</param>
        static public void SettingsHeaderAndFooter(Document doc)
        {
            foreach (Section wordSection in doc.Sections)
            {
                Range headerRange = wordSection.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Collapse(WdCollapseDirection.wdCollapseEnd);

                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldNumPages);

                Paragraph p4 = headerRange.Paragraphs.Add();
                p4.Range.Text = " of ";
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
            }
        }
    }
}
