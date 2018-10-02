#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_DB_SCOUT.Classes;
#endregion

namespace Projet_DB_SCOUT.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_T_Liaison_G : ADBase
 {
  #region Constructeurs
  public A_T_Liaison_G(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? Id_Activite, int? Id_Anime)
  {
   CreerCommande("AjouterT_Liaison_G");
   int res = 0;
   Commande.Parameters.Add("Id_Liaison_G", SqlDbType.Int);
   Direction("Id_Liaison_G", ParameterDirection.Output);
   if(Id_Activite == null) Commande.Parameters.AddWithValue("@Id_Activite", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Activite", Id_Activite);
   if(Id_Anime == null) Commande.Parameters.AddWithValue("@Id_Anime", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Anime", Id_Anime);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Id_Liaison_G"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Id_Liaison_G, int? Id_Activite, int? Id_Anime)
  {
   CreerCommande("ModifierT_Liaison_G");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Liaison_G", Id_Liaison_G);
   if(Id_Activite == null) Commande.Parameters.AddWithValue("@Id_Activite", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Activite", Id_Activite);
   if(Id_Anime == null) Commande.Parameters.AddWithValue("@Id_Anime", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Anime", Id_Anime);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Liaison_G> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Liaison_G");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Liaison_G> res = new List<C_T_Liaison_G>();
   while (dr.Read())
   {
    C_T_Liaison_G tmp = new C_T_Liaison_G();
    tmp.Id_Liaison_G = int.Parse(dr["Id_Liaison_G"].ToString());
   if(dr["Id_Activite"] != DBNull.Value) tmp.Id_Activite = int.Parse(dr["Id_Activite"].ToString());
   if(dr["Id_Anime"] != DBNull.Value) tmp.Id_Anime = int.Parse(dr["Id_Anime"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Liaison_G Lire_ID(int Id_Liaison_G)
  {
   CreerCommande("SelectionnerT_Liaison_G_ID");
   Commande.Parameters.AddWithValue("@Id_Liaison_G", Id_Liaison_G);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Liaison_G res = new C_T_Liaison_G();
   while (dr.Read())
   {
    res.Id_Liaison_G = int.Parse(dr["Id_Liaison_G"].ToString());
   if(dr["Id_Activite"] != DBNull.Value) res.Id_Activite = int.Parse(dr["Id_Activite"].ToString());
   if(dr["Id_Anime"] != DBNull.Value) res.Id_Anime = int.Parse(dr["Id_Anime"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Id_Liaison_G)
  {
   CreerCommande("SupprimerT_Liaison_G");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Liaison_G", Id_Liaison_G);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
