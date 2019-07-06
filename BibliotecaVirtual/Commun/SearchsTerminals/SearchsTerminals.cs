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
            CreateInitiativeFolder();
            //CreateComponentsFolder();
            //CreatePilotSolutionsFolder();
            //CreatePostersFolder();
        }


        public void SearchByKeyAndType(string key, TypeSearch type)
        {
            // todo search inside folders
        }

        public void CreateInitiativeFolder()
        {
            this._folders = new List<Folder>();
            Folder initiative = new Folder
            {
                Name = "Iniciativa_Biofin"
            };

            List<Documents> initDocuments = new List<Documents>
                {
                    new Documents
                    {
                        Url = "Informe_final",
                        Name = "Informe final",
                        Keys = new List<string>() { "key1", "key2" }
                    },
                     new Documents
                    {
                        Url = "Resumen_ejecutivo",
                        Name = "Resumen ejecutivo",
                        Keys = new List<string>() { "key1", "key2" }
                    },
                      new Documents
                    {
                        Url = "Estrategia_de_salida",
                        Name = "Estrategia de salida",
                        Keys = new List<string>() { "key1", "key2" }
                    },
                        new Documents
                    {
                        Url = "Lecciones_aprendidas",
                        Name = "Lecciones aprendidas",
                        Keys = new List<string>() { "key1", "key2" }
                    },
                };

            Folder initComponentsFolder = new Folder
            {
                Name = "Informes por componentes",
            };

            Folder initPilotsSolutionsFolder = new Folder
            {
                Name = "Sitios de Implementación de las soluciones pilotos",
            };

            Folder initPostersFolder = new Folder
            {
                Name = "Posters",
            };

            Folder initGalleryFolder = new Folder
            {
                Name = "Galeria",
            };

            //Adding contents to initiative folder 
            initiative.Documents = initDocuments;
            initiative.Folders.Add(initComponentsFolder);
            initiative.Folders.Add(initPilotsSolutionsFolder);
            initiative.Folders.Add(initPostersFolder);
            initiative.Folders.Add(initGalleryFolder);

            //Adding Initiative folder to Folder Root
            this._folders.Add(initiative);
        }
    }
}