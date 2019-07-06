namespace Biblio.Business.Service.Helpers
{
    public class Par
    {
        public Par(long id, string tipo)
        {
            Id = id;
            TipoDocumento = tipo;
        }
        public long Id { get; set; }
        public string TipoDocumento { get; set; }
    }
}
