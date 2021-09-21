using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;

namespace WebApplication1
{
    public class ApiProvincias
    {
        private List<Provincias> ProvinciasArgentinas;


        public ApiProvincias()
        {
            ProvinciasArgentinas = GetWebServiceArgentina();
        }

        private static List<Provincias> GetWebServiceArgentina()
        {
            var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            List<Provincias> LocalProvincia = null;
            //List<Root> miroot = null;
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        using (StreamReader objectReader = new StreamReader(strReader))
                        {
                            string responseBody = objectReader.ReadToEnd();
                            Root Prov = JsonSerializer.Deserialize<Root>(responseBody);
                              /*  foreach (Provincias item in Prov.Provincias)
                                {
                                    Console.WriteLine(item.Nombre+item.Id);
                                
                                }*/
                        //  miroot.AddRange(Prov);
                                LocalProvincia=Prov.Provincias;
                                foreach (var item in LocalProvincia)
                                {
                                    Console.WriteLine(item.Nombre + item.Id);

                                }

                            }
                    }

                }


            }
            catch (WebException ex)
            {
                throw new Exception("Hubo un error con el servicio web");
            }
            return LocalProvincia.OrderBy(x => x.Nombre).ToList(); ; 
        }

        public List<Provincias> GetListadoDeProv()
        {
            return ProvinciasArgentinas;
        }

        public void ActualizarProvincias()
        {
            List<Provincias> Prov = null;
            if ((Prov= GetListadoDeProv()) != null)
            {
               ProvinciasArgentinas=Prov;
            }
        }

    }
}
