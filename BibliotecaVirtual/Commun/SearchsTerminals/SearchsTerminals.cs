using System.Collections.Generic;
using System.Linq;

namespace BibliotecaVirtual.Commun.SearchsTerminals
{
    public enum TypeSearch
    {
        All=0,
        COMPONENTS1=1,
        COMPONENTS2 = 2,
        COMPONENTS3 = 3,
        COMPONENTS4 = 4,
        POSTERS =5,
        PILOTSSOLUTIONS=6
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


        public List<Documents> SearchByKeyAndType(string key, TypeSearch type)
        {
            var results = new List<Documents>();
            switch ((int)type)
            {
                case 1:
                    results = SearchInComponent1(key);
                    break;
                case 2:
                    results = SearchInComponent2(key);
                    break;
                case 3:
                    results = SearchInComponent3(key);
                    break;
                case 4:
                    results = SearchInComponent4(key);
                    break;
                case 5:
                    results = SearchInPosters(key);
                    break;
                case 6:
                    results = SearchInPilotSolutions(key);
                    break;
                default:
                    results = SearchInAllFiles(key);
                    break;
            }

            return results;
        }

        private List<Documents> SearchInAllFiles(string key)
        {
            throw new System.NotImplementedException();
        }

        private List<Documents> SearchInPilotSolutions(string key)
        {
            throw new System.NotImplementedException();
        }

        private List<Documents> SearchInPosters(string key)
        {
            var results = new List<Documents>();
            Folder postersFolder = this._folders[0].Folders[2];
            return SearchInDocuments(key, postersFolder);
        }

        private List<Documents> SearchInComponent4(string key)
        {
            throw new System.NotImplementedException();
        }

        private List<Documents> SearchInComponent3(string key)
        {
            throw new System.NotImplementedException();
        }

        private List<Documents> SearchInComponent2(string key)
        {
            throw new System.NotImplementedException();
        }

        private List<Documents> SearchInComponent1(string key)
        {
            throw new System.NotImplementedException();
        }

        private static List<Documents> SearchInDocuments(string key, Folder folderToSearch)
        {
            List<Documents> results;
            results = folderToSearch.Documents.Where(find => find.Name.Contains(key) ||
                                                             find.Keys.Contains(key))
                .OrderByDescending(n => n.Name)
                .ToList();
            return results;
        }

        #region Seed for folders


        public void CreateInitiativeFolder()
        {
            this._folders = new List<Folder>();
            Folder initiative = new Folder
            {
                Name = "Iniciativa_Biofin",
                Folders = new List<Folder>()
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
                Folders = new List<Folder>()
            };

            Folder initPilotsSolutionsFolder = new Folder
            {
                Name = "Sitios de Implementación de las soluciones pilotos",
                Folders = new List<Folder>()
            };

            Folder initPostersFolder = new Folder
            {
                Name = "Posters",
                Folders = new List<Folder>()
            };

            Folder initGalleryFolder = new Folder
            {
                Name = "Galeria",
                Folders = new List<Folder>()
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
                Folders = new List<Folder>()
            };
            Folder component2Folder = new Folder
            {
                Name = "Componente 2",
                Folders = new List<Folder>()
            };
            Folder component3Folder = new Folder
            {
                Name = "Componente 3",
                Folders = new List<Folder>()
            };
            Folder component4Folder = new Folder
            {
                Name = "Componente 4",
                Folders = new List<Folder>()
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
            component1.Folders = new List<Folder>();

            Folder compResolutionsFolder = new Folder
            {
                Name = "Resoluciones",
                Folders = new List<Folder>()
            };

            List<Documents> component1Documents = new List<Documents>
            {
                new Documents
                {
                    Url = "Informe_final",
                    Name = "Informe final",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            component1.Folders.Add(compResolutionsFolder);
            component1.Documents = component1Documents;
            CreateComponent1Resolutions();
        }

        private void CreateComponent1Resolutions()
        {
            Folder comp1Resolutions = this._folders[0].Folders[0].Folders[0].Folders[0];
            List<Documents> resolutionsDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = "Doc_1",
                    Name = "Doc 1",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_2",
                    Name = "Doc 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_3",
                    Name = "Doc 3",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            comp1Resolutions.Documents = resolutionsDocuments;
        }

        public void CreateComponent2()
        {
            Folder component2 = this._folders[0].Folders[0].Folders[1];

            Folder compMethodologiesFolder = new Folder
            {
                Name = "Metodologías",
                Folders = new List<Folder>()
            };

            List<Documents> component2Documents = new List<Documents>
            {
                new Documents
                {
                    Url = "Informe_final",
                    Name = "Informe final",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            component2.Folders.Add(compMethodologiesFolder);
            component2.Documents = component2Documents;
            CreateComponent2Methodologies();
        }

        private void CreateComponent2Methodologies()
        {
            Folder comp2Methodologies = this._folders[0].Folders[0].Folders[1].Folders[0];
            List<Documents> methodologiesDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = "Doc_1",
                    Name = "Doc 1",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_2",
                    Name = "Doc 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_3",
                    Name = "Doc 3",
                    Keys = new List<string>() { "key1", "key2" }
                },
            };
            comp2Methodologies.Documents = methodologiesDocuments;
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
            component3.Documents = component3Documents;
        }


        public void CreateComponent4()
        {
            Folder component4 = this._folders[0].Folders[0].Folders[3];
            Folder compResolutionsFolder = new Folder
            {
                Name = "Resoluciones",
                Folders = new List<Folder>()
            };
            Folder compFinancialSolutionsSheetsFolder = new Folder
            {
                Name = "Fichas de soluciones financieras",
                Folders = new List<Folder>()
            };

            List<Documents> component4Documents = new List<Documents>
            {
                new Documents
                {
                    Url = "Informe_final",
                    Name = "Informe final",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Plan_financiero",
                    Name = "Plan financiero",
                    Keys = new List<string>() { "key1", "key2" }
                },
            };
            component4.Folders.Add(compResolutionsFolder);
            component4.Folders.Add(compFinancialSolutionsSheetsFolder);
            component4.Documents = component4Documents;
            CreateComponent4Resolutions();
            CreateComponent4FinancialSolutionSheets();
        }

        private void CreateComponent4Resolutions()
        {
            Folder comp4Resolutions = this._folders[0].Folders[0].Folders[3].Folders[0];
            List<Documents> resolutionsDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = "Doc_1",
                    Name = "Doc 1",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_2",
                    Name = "Doc 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_3",
                    Name = "Doc 3",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            comp4Resolutions.Documents = resolutionsDocuments;
        }

        private void CreateComponent4FinancialSolutionSheets()
        {
            Folder comp4FinancialSolutions = this._folders[0].Folders[0].Folders[3].Folders[1];
            List<Documents> financialSolutionsDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = "Doc_1",
                    Name = "Doc 1",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_2",
                    Name = "Doc 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_3",
                    Name = "Doc 3",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            comp4FinancialSolutions.Documents = financialSolutionsDocuments;
        }

        public void CreatePilotSolutionsFolder()
        {
            Folder pilotSolutionsFolder = this._folders[0].Folders[1];
            List<Documents> pilotSolutionsDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = "Doc_1",
                    Name = "Doc 1",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_2",
                    Name = "Doc 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_3",
                    Name = "Doc 3",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            pilotSolutionsFolder.Documents = pilotSolutionsDocuments;
        }

        public void CreatePostersFolder()
        {
            Folder postersFolder = this._folders[0].Folders[2];
            List<Documents> postersDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = "Doc_1",
                    Name = "Doc 1",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_2",
                    Name = "Doc 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = "Doc_3",
                    Name = "Doc 3",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            postersFolder.Documents = postersDocuments;
        }
        #endregion

    }
}