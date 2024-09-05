using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaFacturacion.DTO
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public TipoUsuario Tipo_usuario { get; set; }
        public string Nombre_usuario { get; set; }
        public string Contrasenia{ get; set; }
        public bool Activo { get; set; }

        public Usuario()
        {
            Tipo_usuario = new TipoUsuario();
        }
       
        public string getXml()
        {
            XElement xml_usuario = new XElement("Usuario");
            xml_usuario.Add(new XElement("Id_usuario", Id_usuario));
            xml_usuario.Add(new XElement("Tipo_usuario", Tipo_usuario.Id_tipo_usuario));
            xml_usuario.Add(new XElement("Usuario", Nombre_usuario));
            xml_usuario.Add(new XElement("Contrasenia", Contrasenia));
            xml_usuario.Add(new XElement("Activo", Activo));

            return xml_usuario.ToString();
        }
    }
}
