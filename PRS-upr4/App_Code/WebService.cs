using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public int Add(int a, int b)
    {
        return a + b;
    }

    [WebMethod]
    public float Farenheit2Celsius(float temp_f)
    {
        return (temp_f - 32f) / 9f * 5f;
    }

    [WebMethod]
    public float Celsius2Farenheit(float temp_c)
    {
        return (temp_c * 9f / 5f) + 32f;
    }

    [WebMethod]
    public string LoadJSON(string file_name)
    {
        string json_files_location = "C:\\Users\\danim\\source\\repos\\PRS-upr4\\PRS-upr4\\JSON_Files\\";
        try
        {
            using (StreamReader r = new StreamReader(json_files_location+file_name))
            {
                return r.ReadToEnd();
            } 
        } catch
        {
            return "Couldn't find file!";
        }
    }
}
