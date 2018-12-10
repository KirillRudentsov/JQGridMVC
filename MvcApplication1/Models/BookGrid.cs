using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Trirand.Web.Mvc;

namespace MvcApplication1.Models
{
    public class BookGrid
    {
        public JQGrid BooksGrid { get; set; }

        public BookGrid()
        {

            BooksGrid = new JQGrid
            {
                LoadOnce = true,
                DataUrl = "Home/GetData",
                Columns = new List<JQGridColumn>()
                                 {
                                     new JQGridColumn { DataField = "Id", 
                                                        // always set PrimaryKey for Add,Edit,Delete operations
                                                        // if not set, the first column will be assumed as primary key
                                                        PrimaryKey = true,
                                                        Editable = false,
                                                        Width = 50 },
                                     new JQGridColumn { DataField = "Author",
                                                        Editable = true,
                                                        Width = 100 },
                                     new JQGridColumn { DataField = "Name",
                                                        Editable = true,
                                                        Width = 100 },
                                     new JQGridColumn { DataField = "Price",
                                                        Editable = true,
                                                        Width = 75 },
                                     new JQGridColumn { DataField = "Year",
                                                        Editable =  true
                                                      }
                                 },
                Width = Unit.Pixel(640),

                Height = Unit.Pixel(400)
            };

            BooksGrid.ToolBarSettings.ShowRefreshButton = true;
        }
    }
}