using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Association
{
    public Association(string title)
    {
        Title = title;
    }
    public Association(string title, string detail)
    {
        Title = title;
        Detail = detail;
    }

    public int ID { get; set; }
    public string Title { get; set; }
    public string Detail { get; set; }
}
