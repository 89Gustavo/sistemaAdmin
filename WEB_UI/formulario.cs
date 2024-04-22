using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_UI
{
    public class formulario
    {
        public formulario() { }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Botone
        {
            public string nombre { get; set; }
            public string evento { get; set; }
        }

        public class Datum
        {
            public Formulario formulario { get; set; }
            public List<Objeto> objetos { get; set; }
            public List<Botone> botones { get; set; }
        }

        public class Formulario
        {
            public string codigoFormulaio { get; set; }
            public string nombreFormView { get; set; }
            public string titulo { get; set; }
            public string subtitulo { get; set; }
            public string sperInsert { get; set; }
            public string sprUpdate { get; set; }
            public string sprSelect { get; set; }
            public string javascriptOnload { get; set; }
            public int estatus { get; set; }
        }

        public class Objeto
        {
            public int codigoObjeto { get; set; }
            public string campoTag { get; set; }
            public string titulo { get; set; }
            public int orden { get; set; }
            public int position { get; set; }
            public int tipoDato { get; set; }
            public int logintudMinima { get; set; }
            public int longitudMaxima { get; set; }
            public int estatus { get; set; }
        }

        public class Resultado
        {
            public List<Datum> data { get; set; }
        }


    }
}