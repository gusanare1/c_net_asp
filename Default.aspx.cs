using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Threading.Tasks;

public partial class _Default : Page
{

    string url = "http://gusanare.pythonanywhere.com/vehiculo/lista/";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write("KDK");
        //getData();
    }

    /// <summary>
    /// getData obtengo get api rest
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    public void getData(Object sender,
                           EventArgs e)
    {
        dd().Wait();
    }
    public async Task dd() 
    {
        Response.Write("LS");

        var request = (HttpWebRequest)WebRequest.Create(url);
        var response = (HttpWebResponse)request.GetResponse();
        string responseString;
        using (var stream = response.GetResponseStream())
        {
            using (var reader = new StreamReader(stream))
            {
                responseString = reader.ReadToEnd();
            }
        }

        List<Empleado> list_emp = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Empleado>>(responseString);
            foreach (Empleado emp_t in list_emp)
            {
                lbltxt.Text = lbltxt.Text+"\n"+emp_t.ToString();
            }
            //Response.Write(emp);
            Response.Write("END:::");
        
    }
    private static HttpClient Client = new HttpClient();


    public void asd(Object sender, EventArgs e)
    {
        request().Wait();
    }

    public async Task request()
    {

        Empleado em = new Empleado();
        em.id = 6;
        em.name = "JS";
        em.rating = 10;
        em.release_date = "2012-10-20";
        em.category = "drama";
        string json = new JavaScriptSerializer().Serialize(em);

        Response.Write(json);



        var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Accept = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();
        }

        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        /*
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            Response.Write(result);
        }
        */

    }



   
}
