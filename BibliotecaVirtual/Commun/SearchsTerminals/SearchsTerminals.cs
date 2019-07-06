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
            CreateComponentsFolder();
            CreatePilotSolutionsFolder();
            CreatePostersFolder();
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

        public void CreateComponentsFolder()
        {
            Folder componentFolder = this._folders[0].Folders[0];

            Folder component1Folder = new Folder
            {
                Name = "Componente 1",
            };
            Folder component2Folder = new Folder
            {
                Name = "Componente 2",
            };
            Folder component3Folder = new Folder
            {
                Name = "Componente 3",
            };
            Folder component4Folder = new Folder
            {
                Name = "Componente 4",
            };
            componentFolder.Folders.Add(component1Folder);
            componentFolder.Folders.Add(component2Folder);
            componentFolder.Folders.Add(component3Folder);
            componentFolder.Folders.Add(component4Folder);

            CreateComponent1();
            CreateComponent2();
            CreateComponent3();
            CreateComponent4();

        }

        public void CreateComponent1()
        {
            Folder component1 = this._folders[0].Folders[0].Folders[0];

            List<Documents> component1Documents = new List<Documents>
            {
                new Documents
                {
                    Url = "Informe_final",
                    Name = "Informe final",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
        }

        public void CreateComponent2()
        {
            Folder component2 = this._folders[0].Folders[0].Folders[1];
            List<Documents> component2Documents = new List<Documents>
            {
                new Documents
                {
                    Url = "Informe_final",
                    Name = "Informe final",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
        }
        public void CreateComponent3()
        {
            Folder component3 = this._folders[0].Folders[0].Folders[2];
            List<Documents> component3Documents = new List<Documents>
            {
                new Documents
                {
                    Url = "Informe_final",
                    Name = "Informe final",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
        }
        public void CreateComponent4()
        {
            Folder component4 = this._folders[0].Folders[0].Folders[3];
            List<Documents> component1Documents = new List<Documents>
            {
                new Documents
                {
                    Url = "Informe_final",
                    Name = "Informe final",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Fichas_soluciones_financieras",
                    Name = "Fichas de soluciones financieras",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Plan_financiero",
                    Name = "Plan financiero",
                    Keys = new List<string>() { "key1", "key2" }
                },
            };
        }

        public void CreatePilotSolutionsFolder()
        {
            Folder pilotSolutionsFolder = this._folders[0].Folders[1];

        }

        public void CreatePostersFolder()
        {
            Folder postersFolder = this._folders[0].Folders[2];

        }
    }
}