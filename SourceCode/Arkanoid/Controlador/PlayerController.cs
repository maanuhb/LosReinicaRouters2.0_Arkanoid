using System;
using System.Collections.Generic;
using System.Data;

namespace Arkanoid
{
    public static class PlayerController
    {
        #region createPlayer
        public static bool CreatePlayer(string nickname)
        {
            var dt = ArkanoidDBcn.ExecuteQuery($"SELECT * FROM PLAYER WHERE nickname = '{nickname}' ");

            if (dt.Rows.Count > 0)
                return true;
            else
            {
                ArkanoidDBcn.ExecuteNonquery("INSERT INTO PLAYER(nickname) VALUES " +
                                             $"('{nickname}')");
                return false;
            }
        }
        #endregion

        #region playerList
        public static List<Player> ObtainTopPlayers() 
        {
            var TopPlayers = new List<Player>();
            DataTable dt = ArkanoidDBcn.ExecuteQuery("SELECT pl.nickname, sc.score " + 
                                                        "FROM PLAYER pl, SCORE sc " + 
                                                        "WHERE pl.idPlayer = sc.idPlayer " +
                                                        "ORDER BY sc.score DESC " +
                                                        "LIMIT 10");

            foreach (DataRow dr in dt.Rows)
            {
             TopPlayers.Add(new Player(dr[0].ToString(), Convert.ToInt32(dr[1])));   
            }
            
            return TopPlayers;
        }
        #endregion
    }
}