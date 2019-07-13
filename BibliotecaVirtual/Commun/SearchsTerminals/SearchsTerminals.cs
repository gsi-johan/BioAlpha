﻿using System;
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
        PILOTSSITES=6,
        ALLCOMPONENTS=7
    }

    public class SearchsTerminals
    {
        private List<Folder> _folders;
        private static SearchsTerminals _searchsTerminals = null;
        private const String InitiativePath = "\\Documentos\\Iniciativa_Biofin\\";

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
                    results = SearchInPilotSites(key);
                    break;
                case 7:
                    results = AllComponents();
                    break;
                default:
                    results = SearchInAllFiles(key);
                    break;
            }

            return results;
        }

        private List<Documents> SearchInAllFiles(string key)
        {
            var results = new List<Documents>();
            Folder allFolders = this._folders[0];
            return SearchInAllDocuments(key, allFolders);
        }

        private List<Documents> AllComponents()
        {
            var results = new List<Documents>();
            results.AddRange(SearchInComponent1(""));
           results.AddRange(SearchInComponent2(""));
           results.AddRange(SearchInComponent3(""));
           results.AddRange(SearchInComponent4(""));
            return results;
        }

        private List<Documents> SearchInPilotSites(string key)
        {
            var results = new List<Documents>();
            Folder folderToSearch = this._folders[0].Folders[1];

            if (folderToSearch.Documents != null)
            {
                results = folderToSearch.Documents.Where(find => find.Name.ToLower().Contains(key) ||
                                                                 find.Keys.Any(k => k.ToLower().Contains(key)))
                    .OrderByDescending(n => n.Name)
                    .ToList();
            }
            int foldersCount = folderToSearch.Folders.Count - 1;
            while (foldersCount >= 0)
            {
                results.AddRange(folderToSearch.Folders[foldersCount].Documents.Where(find => find.Name.ToLower().Contains(key) || find.Keys.Any(k => k.ToLower().Contains(key)))
                    .OrderByDescending(n => n.Name)
                    .ToList());

                foldersCount--;
            }
            return results;
        }

        private List<Documents> SearchInPosters(string key)
        {
            var results = new List<Documents>();
            Folder postersFolder = this._folders[0].Folders[2];
            if (string.IsNullOrEmpty(key))
            {
                results.AddRange(postersFolder.Documents);
                return results;
            }
            return SearchInDocuments(key, postersFolder);
        }

        private List<Documents> SearchInComponent4(string key)
        {
            var results = new List<Documents>();
            Folder component4 = this._folders[0].Folders[0].Folders[3];
            if (string.IsNullOrEmpty(key))
            {
                results.AddRange(component4.Documents);
                results.AddRange(component4.Folders[0].Documents);
                results.AddRange(component4.Folders[1].Documents);
                return results;
            }
            return SearchInDocuments(key, component4);
        }

        private List<Documents> SearchInComponent3(string key)
        {
            var results = new List<Documents>();
            Folder component3 = this._folders[0].Folders[0].Folders[2];
            if (string.IsNullOrEmpty(key))
            {
                results.AddRange(component3.Documents);
                return results;
            }
            return SearchInDocuments(key, component3);
        }

        private List<Documents> SearchInComponent2(string key)
        {
            var results = new List<Documents>();
            Folder component2 = this._folders[0].Folders[0].Folders[1];
            if (string.IsNullOrEmpty(key))
            {
                results.AddRange(component2.Documents);
                results.AddRange(component2.Folders[0].Documents);
                return results;
            }
            return SearchInDocuments(key, component2);
        }

        private List<Documents> SearchInComponent1(string key)
        {
            var results = new List<Documents>();
            Folder component1 = this._folders[0].Folders[0].Folders[0];
            if (string.IsNullOrEmpty(key))
            {
                results.AddRange(component1.Documents);
                results.AddRange(component1.Folders[0].Documents);
                return results;
            }
           
            return SearchInDocuments(key, component1);
        }

        private List<Documents> SearchInDocuments(string key, Folder folderToSearch)
        {
            List<Documents> results = new List<Documents>();

            if (folderToSearch.Documents != null)
            {
                results = folderToSearch.Documents.Where(find => find.Name.ToLower().Contains(key) ||
                                                                 find.Keys.Any(k => k.ToLower().Contains(key)))
                    .OrderByDescending(n => n.Name)
                    .ToList();
            }
            int foldersCount = folderToSearch.Folders.Count -1;
            while (foldersCount >= 0)
            {
                results.AddRange(folderToSearch.Folders[foldersCount].Documents.Where(find => find.Name.ToLower().Contains(key) ||find.Keys.Any(k => k.ToLower().Contains(key)))
                    .OrderByDescending(n => n.Name)
                    .ToList());

                foldersCount--;
            }
            
            return results;
        }

        private List<Documents> SearchInAllDocuments(string key, Folder folderToSearch)
        {
            List<Documents> results = new List<Documents>();

            if (folderToSearch.Documents != null)
            {
                results = folderToSearch.Documents.Where(find => find.Name.ToLower().Contains(key) ||
                                                                 find.Keys.Any(k => k.ToLower().Contains(key)))
                    .OrderByDescending(n => n.Name)
                    .ToList();
            }
            int foldersCount = folderToSearch.Folders.Count - 1;
            while (foldersCount >= 0)
            {
                results.AddRange(folderToSearch.Folders[foldersCount].Documents.Where(find => find.Name.ToLower().Contains(key) || find.Keys.Any(k => k.ToLower().Contains(key)))
                    .OrderByDescending(n => n.Name)
                    .ToList());

                foldersCount--;
            }

            results.AddRange(SearchInPilotSites(key));
            results.AddRange(SearchInComponent1(key));
            results.AddRange(SearchInComponent2(key));
            results.AddRange(SearchInComponent3(key));
            results.AddRange(SearchInComponent4(key));

            return results;
        }


        #region Seed for folders

        public void CreateInitiativeFolder()
        {
            this._folders = new List<Folder>();
            Folder initiative = new Folder
            {
                Name = "Iniciativa_Biofin",
                Folders = new List<Folder>(),
                Documents = new List<Documents>()
            };

            #region Documents Initiative
            List<Documents> initDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = InitiativePath + "Informe Final Componentes.pdf",
                    Name = "Informe Final Componentes",
                    Keys = new List<string>() { "general", "conclusiones" }
                },
                new Documents
                {
                    Url = InitiativePath +"Resumen Ejecutivo.pdf",
                    Name = "Resumen Ejecutivo",
                    Keys = new List<string>() { "resumen", "general" }
                },
                new Documents
                {
                    Url = InitiativePath +"Estrategia de Salida.pdf",
                    Name = "Estrategia de Salida",
                    Keys = new List<string>() { "estrategia", "economia" }
                },
                new Documents
                {
                    Url = InitiativePath +"Lecciones Aprendidas.pdf",
                    Name = "Lecciones Aprendidas",
                    Keys = new List<string>() { "MINAGRI", "lecciones" }
                },
            };

            #endregion

            Folder initComponentsFolder = new Folder
            {
                Name = "Components",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = InitiativePath + "Components\\"
            };

            Folder initPilotsSitesFolder = new Folder
            {
                Name = "Pilots_Sites",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = InitiativePath + "Pilots_Sites\\"
            };

            Folder initPostersFolder = new Folder
            {
                Name = "Posters",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = InitiativePath + "Posters\\"
            };

            Folder initGalleryFolder = new Folder
            {
                Name = "Gallery",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = InitiativePath + "Gallery\\"
            };

            //Adding contents to initiative folder 
            initiative.Documents = initDocuments;
            initiative.Folders.Add(initComponentsFolder);
            initiative.Folders.Add(initPilotsSitesFolder);
            initiative.Folders.Add(initPostersFolder);
            initiative.Folders.Add(initGalleryFolder);

            //Adding Initiative folder to Folder Root
            this._folders.Add(initiative);
        }

        public void CreateComponentsFolder()
        {
            Folder componentFolder = this._folders[0].Folders[0];
            string componentsPath = InitiativePath + "\\Components\\";

            #region Components folders

            Folder component1Folder = new Folder
            {
                Name = "Componente 1",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = componentsPath + "Component_1\\"
            };
            Folder component2Folder = new Folder
            {
                Name = "Componente 2",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = componentsPath + "Component_2\\"
            };
            Folder component3Folder = new Folder
            {
                Name = "Componente 3",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = componentsPath + "Component_3\\"
            };
            Folder component4Folder = new Folder
            {
                Name = "Componente 4",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = componentsPath + "Component_4\\"
            };
            componentFolder.Folders.Add(component1Folder);
            componentFolder.Folders.Add(component2Folder);
            componentFolder.Folders.Add(component3Folder);
            componentFolder.Folders.Add(component4Folder);

            #endregion

            CreateComponent1();
            CreateComponent2();
            CreateComponent3();
            CreateComponent4();

        }

        public void CreateComponent1()
        {
            Folder component1 = this._folders[0].Folders[0].Folders[0];
            component1.Folders = new List<Folder>();

            List<Documents> component1Documents = new List<Documents>
            {
                new Documents
                {
                    Url = component1.FolderUrl +"Informe final Componente 1.pdf",
                    Name = "Informe final Componente 1",
                    Keys = new List<string>() { "Componente 1", "Conclusion","economia cubana" }
                },
                new Documents
                {
                    Url = component1.FolderUrl +"Resumen Componente 1.pdf",
                    Name = "Resumen Componente 1",
                    Keys = new List<string>() { "Componente 1", "Resumen","Conclusiones" }
                }
            };
            component1.Documents = component1Documents;
        }

        /// <summary>
        /// Deprecated
        /// </summary>
        private void CreateComponent1Resolutions()
        {
            Folder comp1Resolutions = this._folders[0].Folders[0].Folders[0].Folders[0];

            List<Documents> resolutionsDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = comp1Resolutions.FolderUrl+"Res 101 Componente 1.pdf",
                    Name = "Res 101 Componente 1",
                    Keys = new List<string>() { "Documento", "componente 1" }
                },
                new Documents
                {
                    Url = comp1Resolutions.FolderUrl+"Res 102 Componente 1.pdf",
                    Name = "Res 102 Componente 1",
                    Keys = new List<string>() { "MINAGRI", "agricultura" }
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
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = component2.FolderUrl + "Methodologies\\"
            };

            List<Documents> component2Documents = new List<Documents>
            {
                new Documents
                {
                    Url = component2.FolderUrl+"Informe final Componente 2.pdf",
                    Name = "Informe final Componente 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = component2.FolderUrl+"Resumen Componente 2.pdf",
                    Name = "Resumen Componente 2",
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
                    Url = comp2Methodologies.FolderUrl+"METODOLOGIA AGBD CUBA.pdf",
                    Name = "Metodología AGBD Cuba",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            comp2Methodologies.Documents = methodologiesDocuments;
        }

        public void CreateComponent3()
        {
            Folder component3 = this._folders[0].Folders[0].Folders[2];
            Folder compMethodologiesFolder = new Folder
            {
                Name = "Metodologías",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = component3.FolderUrl + "Methodologies\\"
            };

            List<Documents> component3Documents = new List<Documents>
            {
                new Documents
                {
                    Url = component3.FolderUrl+"Informe final Componente 3.pdf",
                    Name = "Informe final Componente 3",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = component3.FolderUrl+"Resumen Componente 3.pdf",
                    Name = "Resumen Componente 3",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            component3.Documents = component3Documents;
            component3.Folders.Add(compMethodologiesFolder);
            CreateComponent3Methodologies();
        }

        private void CreateComponent3Methodologies()
        {
            Folder comp3Methodologies = this._folders[0].Folders[0].Folders[2].Folders[0];
            List<Documents> methodologiesDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = comp3Methodologies.FolderUrl+"METODOLOGIA FNA CUBA.pdf",
                    Name = "Metodología FNA Cuba",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            comp3Methodologies.Documents = methodologiesDocuments;
        }


        public void CreateComponent4()
        {
            Folder component4 = this._folders[0].Folders[0].Folders[3];
            
            Folder compFinancialSolutionsSheetsFolder = new Folder
            {
                Name = "Fichas de soluciones financieras",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = component4.FolderUrl + "Financial_Solutions\\"
            };

            List<Documents> component4Documents = new List<Documents>
            {
                new Documents
                {
                    Url = component4.FolderUrl+"Informe final Componente 4.pdf",
                    Name = "Informe final Componente 4",
                    Keys = new List<string>() { "componente 4", "conclusiones" }
                },
                new Documents
                {
                    Url = component4.FolderUrl+"Plan Financiero hasta 2025.pptx",
                    Name = "Plan Financiero hasta 2025.pptx",
                    Keys = new List<string>() { "economia cubana", "key2" }
                },
                new Documents
                {
                    Url = component4.FolderUrl+"Resumen Componente 4.pdf",
                    Name = "Resumen Componente 4",
                    Keys = new List<string>() { "economia cubana", "key2" }
                },
            };
            component4.Folders.Add(compFinancialSolutionsSheetsFolder);
            component4.Documents = component4Documents;
            CreateComponent4FinancialSolutionSheets();
        }

        /// <summary>
        /// DEPRECATED
        /// </summary>
        private void CreateComponent4Resolutions()
        {
            Folder comp4Resolutions = this._folders[0].Folders[0].Folders[3].Folders[0];

            #region Resolutions Component 4

            List<Documents> resolutionsDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 401 Componente 4.pdf",
                    Name = "Res 401 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 402 Componente 4.pdf",
                    Name = "Res 402 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 403 Componente 4.pdf",
                    Name = "Res 403 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 404 Componente 4.pdf",
                    Name = "Res 404 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 405 Componente 4.pdf",
                    Name = "Res 405 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 406 Componente 4.pdf",
                    Name = "Res 406 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 407 Componente 4.pdf",
                    Name = "Res 407 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 408 Componente 4.pdf",
                    Name = "Res 408 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 409 Componente 4.pdf",
                    Name = "Res 409 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 410 Componente 4.pdf",
                    Name = "Res 410 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 411 Componente 4.pdf",
                    Name = "Res 411 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4Resolutions.FolderUrl+"Res 412 Componente 4.pdf",
                    Name = "Res 412 Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
            };
            comp4Resolutions.Documents = resolutionsDocuments;
            #endregion


        }

        private void CreateComponent4FinancialSolutionSheets()
        {
            Folder comp4FinancialSolutions = this._folders[0].Folders[0].Folders[3].Folders[0];
            List<Documents> financialSolutionsDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = comp4FinancialSolutions.FolderUrl+"Soluciones 1 financieras Componente 4.pdf",
                    Name = "Soluciones 1 financieras Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = comp4FinancialSolutions.FolderUrl+"Soluciones 2 financieras Componente 4.pdf",
                    Name = "Soluciones 2 financieras Componente 4",
                    Keys = new List<string>() { "key1", "key2" }
                },
            };
            comp4FinancialSolutions.Documents = financialSolutionsDocuments;
        }

        public void CreatePilotSolutionsFolder()
        {
            Folder pilotSitesFolder = this._folders[0].Folders[1];
            Folder financialJustificationCienaga = new Folder
            {
                Name = "APRM P C.Zapata",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = pilotSitesFolder.FolderUrl + "APRM P C.ZAPATA\\"
            };
            Folder financialJustificationGuanahacabibes = new Folder
            {
                Name = "PN P.Guanahacabibes",
                Folders = new List<Folder>(),
                Documents = new List<Documents>(),
                FolderUrl = pilotSitesFolder.FolderUrl + "PN P.GUANAHACABIBES\\"
            };
            pilotSitesFolder.Folders.Add(financialJustificationCienaga);
            pilotSitesFolder.Folders.Add(financialJustificationGuanahacabibes);
            CreatePilotSitesFinancialDocumentsCienaga();
            CreatePilotSitesFinancialDocumentsGC();
        }

        private void CreatePilotSitesFinancialDocumentsCienaga()
        {
            Folder pilotSitesCienaga = this._folders[0].Folders[1].Folders[0];
            List<Documents> pilotSitesCienagaDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = pilotSitesCienaga.FolderUrl+"justificacion.pdf",
                    Name = "Ciénaga de Zapata.Justificación Financiera",
                    Keys = new List<string>() { "Ciénaga Zapata", "sitio" }
                }
            };
            pilotSitesCienaga.Documents = pilotSitesCienagaDocuments;

        }

        private void CreatePilotSitesFinancialDocumentsGC()
        {
            Folder pilotSitesGC = this._folders[0].Folders[1].Folders[1];
            List<Documents> pilotSitesGCDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = pilotSitesGC.FolderUrl+"justificacion.pdf",
                    Name = "Guanahacabibes.Justificación Financiera",
                    Keys = new List<string>() { "Guanahacabibes", "sitio" }
                }
            };
            pilotSitesGC.Documents = pilotSitesGCDocuments;

        }

        public void CreatePostersFolder()
        {
            Folder postersFolder = this._folders[0].Folders[2];
            List<Documents> postersDocuments = new List<Documents>
            {
                new Documents
                {
                    Url = postersFolder.FolderUrl+"Poster 1.jpg",
                    Name = "Financiamiento de la Biodiversidad en Cuba una solución financiera actual",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = postersFolder.FolderUrl+"Poster 2.jpg",
                    Name = "Poster 2",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = postersFolder.FolderUrl+"Poster 3.jpg",
                    Name = "Poster 3",
                    Keys = new List<string>() { "key1", "key2" }
                },
                new Documents
                {
                    Url = postersFolder.FolderUrl+"Poster 4.jpg",
                    Name = "Poster 4",
                    Keys = new List<string>() { "key1", "key2" }
                }
            };
            postersFolder.Documents = postersDocuments;
        }
        #endregion

    }
}