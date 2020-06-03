using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_ComicsDB
{
    class Logic
    {
        public enum Tables
        {
            Autor,
            Categoria,
            Comic,
            Exit
        }
        public static Tables TableSelection { get; set; }
        public enum CRUD
        {
            Create,
            Read,
            Update,
            Delete
        }
        public static CRUD CrudSelection { get; set; }

        public static bool Start()
        {
            bool exit=false;
            string[] data;
            TableSelection = (Tables)UserInteraction.TableSelect();
            exit = TableSelection == Tables.Exit;
            if (!exit)
                CrudSelection = (CRUD)UserInteraction.ActionSelect();
            switch (TableSelection)
            {
                case Tables.Autor:
                    switch (CrudSelection)
                    {
                        case CRUD.Create:
                            //Create Autor
                            data = UserInteraction.CreateAutorData();
                            AutorCRUD.Create(data);
                            break;
                        case CRUD.Read:
                            //Read Autor
                            AutorCRUD.Read();
                            break;
                        case CRUD.Update:
                            //Update Autor
                            int id = UserInteraction.IdData();
                            data = UserInteraction.UpdateAutorData();
                            AutorCRUD.Update(id, data);
                            break;
                        case CRUD.Delete:
                            //Delete Autor
                            id = UserInteraction.IdData();
                            AutorCRUD.Delete(id);
                            break;
                    }
                    break;
                case Tables.Categoria:
                    switch (CrudSelection)
                    {
                        case CRUD.Create:
                            //Create Categoria
                            data = UserInteraction.CreateCategoriaData();
                            CategoriaCRUD.Create(data);
                            break;
                        case CRUD.Read:
                            //Read Categoria
                            CategoriaCRUD.Read();
                            break;
                        case CRUD.Update:
                            //Update Categoria
                            int id = UserInteraction.IdData();
                            data = UserInteraction.UpdateCategoriaData();
                            CategoriaCRUD.Update(id, data);
                            break;
                        case CRUD.Delete:
                            //Delete Categoria
                            id = UserInteraction.IdData();
                            CategoriaCRUD.Delete(id);
                            break;
                    }
                    break;
                case Tables.Comic:
                    switch (CrudSelection)
                    {
                        case CRUD.Create:
                            //Create Comic
                            data = UserInteraction.CreateComicData();
                            ComicCRUD.Create(data);
                            break;
                        case CRUD.Read:
                            //Read Comic
                            ComicCRUD.Read();
                            break;
                        case CRUD.Update:
                            //Update Comic
                            int id = UserInteraction.IdData();
                            data = UserInteraction.UpdateComicData();
                            ComicCRUD.Update(id, data);
                            break;
                        case CRUD.Delete:
                            //Delete Comic
                            id = UserInteraction.IdData();
                            ComicCRUD.Delete(id);
                            break;
                    }
                    break;
            }
            return exit;
        }

    }
}
