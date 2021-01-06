using BO;
using DL;
using System.Collections.Generic;


namespace BR
{
    public class Rules
    {
        DataBase db = new DataBase();
        public Utilizador Login(Utilizador currentUser, string email, string senha)
        {

            return db.Login(currentUser, email, senha);

        }

    }
}
