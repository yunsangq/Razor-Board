using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for ClassName
/// </summary>
public class CustomHelper
{
	public CustomHelper()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static String DateTimeParser(string dateTimeString)
    {
        DateTime parseDatetime = DateTime.Now;
        DateTime.TryParse(dateTimeString , out parseDatetime);
        if(parseDatetime > DateTime.Parse(DateTime.Now.ToShortDateString()))
        {
            return parseDatetime.ToShortTimeString();
        }
        return parseDatetime.ToShortDateString();
    }
}