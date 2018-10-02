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
 public class A_T_Liaison_C : ADBase
 {
  #region Constructeurs
  public A_T_Liaison_C(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? Id_Activite, int? Id_Chef1, int? Id_Chef2)
  {
   CreerCommande("AjouterT_Liaison_C");
   int res = 0;
   Commande.Parameters.Add("Id_Liaison_C", SqlDbType.Int);
   Direction("Id_Liaison_C", ParameterDirection.Output);
   if(Id_Activite == null) Commande.Parameters.AddWithValue("@Id_Activite", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Activite", Id_Activite);
   if(Id_Chef1 == null) Commande.Parameters.AddWithValue("@Id_Chef1", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Chef1", Id_Chef1);
   if(Id_Chef2 == null) Commande.Parameters.AddWithValue("@Id_Chef2", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Chef2", Id_Chef2);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Id_Liaison_C"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Id_Liaison_C, int? Id_Activite, int? Id_Chef1, int? Id_Chef2)
  {
   CreerCommande("ModifierT_Liaison_C");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Liaison_C", Id_Liaison_C);
   if(Id_Activite == null) Commande.Parameters.AddWithValue("@Id_Activite", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Activite", Id_Activite);
   if(Id_Chef1 == null) Commande.Parameters.AddWithValue("@Id_Chef1", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Chef1", Id_Chef1);
   if(Id_Chef2 == null) Commande.Parameters.AddWithValue("@Id_Chef2", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Id_Chef2", Id_Chef2);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Liaison_C> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Liaison_C");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Liaison_C> res = new List<C_T_Liaison_C>();
   while (dr.Read())
   {
    C_T_Liaison_C tmp = new C_T_Liaison_C();
    tmp.Id_Liaison_C = int.Parse(dr["Id_Liaison_C"].ToString());
   if(dr["Id_Activite"] != DBNull.Value) tmp.Id_Activite = int.Parse(dr["Id_Activite"].ToString());
   if(dr["Id_Chef1"] != DBNull.Value) tmp.Id_Chef1 = int.Parse(dr["Id_Chef1"].ToString());
   if(dr["Id_Chef2"] != DBNull.Value) tmp.Id_Chef2 = int.Parse(dr["Id_Chef2"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Liaison_C Lire_ID(int Id_Liaison_C)
  {
   CreerCommande("SelectionnerT_Liaison_C_ID");
   Commande.Parameters.AddWithValue("@Id_Liaison_C", Id_Liaison_C);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Liaison_C res = new C_T_Liaison_C();
   while (dr.Read())
   {
    res.Id_Liaison_C = int.Parse(dr["Id_Liaison_C"].ToString());
   if(dr["Id_Activite"] != DBNull.Value) res.Id_Activite = int.Parse(dr["Id_Activite"].ToString());
   if(dr["Id_Chef1"] != DBNull.Value) res.Id_Chef1 = int.Parse(dr["Id_Chef1"].ToString());
   if(dr["Id_Chef2"] != DBNull.Value) res.Id_Chef2 = int.Parse(dr["Id_Chef2"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Id_Liaison_C)
  {
   CreerCommande("SupprimerT_Liaison_C");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Liaison_C", Id_Liaison_C);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
