using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WordTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbWord = new StringBuilder();

            sbWord.Append("<html>");
            sbWord.Append("<head>");
            sbWord.Append("<style>");
            sbWord.Append("@page Section1 {size:595.3pt 841.9pt;margin:12px 20pt;mso-header-margin:4pt;mso-footer-margin:4pt;mso-paper-source:0;}");
            sbWord.Append("div.Section1 {page:Section1;}");
            sbWord.Append("table{width:100%;}");
            sbWord.Append("td{width:50%;height:80pt;}");
            sbWord.Append("td.item-left{border-bottom:1px dotted #000;border-right:1px dotted #000;}");
            sbWord.Append("td.item-right{border-bottom:1px dotted #000;}");
            sbWord.Append(".user-addr{margin-left:5px;}");
            sbWord.Append(".user-name{text-align:center;}");
            sbWord.Append("</style>");
            sbWord.Append("</head>");
            sbWord.Append("<body><div class='Section1'>");
            sbWord.Append(" <table cellspacing='0' cellpadding='0'>");
            for (int i = 0; i < 3; i++)
            {
                //sbWord.Append("     <tr>");
                //sbWord.Append("         <td class='item-left'></td>");
                //sbWord.Append("         <td class='item-right'></td>");
                //sbWord.Append("     </tr>");

                if (i % 2 == 0)
                {
                    sbWord.Append("<tr>");
                    sbWord.Append("<td class='item-left'>");
                }

                if (i % 2 == 1)
                {
                    sbWord.Append("<td class='item-right'>");
                }

                sbWord.Append("<div class='user-addr'> 110 台北市士林區士林區中山北路七段1152巷1弄1928號</div><br/>");
                sbWord.Append("<div class='user-name'>ＸＸＸＸＸＸＸＸＸＸ</div>");
                sbWord.Append("</td>");
                if (i % 2 == 1)
                {
                    sbWord.Append("     </tr>");
                }
            }
            sbWord.Append(" </table>");
            sbWord.Append("</div></body>");
            sbWord.Append("</html>");

            Response.Clear();
            Response.AddHeader("content-disposition", "attachment; filename=ordd.doc");
            Response.ContentType = "application/vnd.ms-word";
            Response.ContentEncoding = System.Text.Encoding.Default;
            Response.Write(sbWord.ToString());
            Response.Flush();
            Response.End();
        }
    }
}