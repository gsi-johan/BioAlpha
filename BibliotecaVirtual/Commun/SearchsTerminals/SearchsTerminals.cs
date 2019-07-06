using System.Collections.Generic;

namespace BibliotecaVirtual.Commun.SearchsTerminals
{
    public enum TypeSearch
    {
        All=0


    }

    public class SearchsTerminals
    {
        private List<Folder> _folders;
        private static SearchsTerminals _searchsTerminals = null;

        public static SearchsTerminals GetIntance()
        {
            if (_searchsTerminals != null) return _searchsTerminals;
            _searchsTerminals = new SearchsTerminals();
            return _searchsTerminals;
        }

        private SearchsTerminals()
        {
            this._folders = new List<Folder>
            {
                new Folder {Name = "Iniciativa_Biofin"}
                
            };
        }


        public void SearchByKeyAndType(string key, TypeSearch type)
        {
            // todo search inside folders
        }
    }
}