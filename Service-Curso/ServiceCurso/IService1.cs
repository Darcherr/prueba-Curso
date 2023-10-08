using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServiceCurso
{

    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        User GetUser(int id);

    }

    [DataContract]
    public class User
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
