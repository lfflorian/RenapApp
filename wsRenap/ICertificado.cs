using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wsRenap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICertificado" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICertificado
    {
        [OperationContract]
        void Certificado(string CUI);
    }
    [DataContract]
    class Persona
    {
        [DataMember]
        public string CUI { get; set; }
        [DataMember]
        public string PrimerNombre { get; set; }
        [DataMember]
        public string SegundoNombre { get; set; }
        [DataMember]
        public string PrimerApellido { get; set; }
        [DataMember]
        public string SegundoApellido { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }
        [DataMember]
        public string Genero { get; set; }
        [DataMember]
        public string LugarNacimiento { get; set; }
        [DataMember]
        public string Obervaciones { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
