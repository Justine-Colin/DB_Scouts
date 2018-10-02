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
 public class A_T_Activite : ADBase
 {
  #region Constructeurs
  public A_T_Activite(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string A_Nom, DateTime? A_Date, int? A_Section, int? A_Chef, int? A_Chef2)
  {
   CreerCommande("AjouterT_Activite");
   int res = 0;
   Commande.Parameters.Add("Id_Activite", SqlDbType.Int);
   Direction("Id_Activite", ParameterDirection.Output);
   if (A_Nom == null) Commande.Parameters.AddWithValue("@A_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Nom", A_Nom);
   if (A_Date == null) Commande.Parameters.AddWithValue("@A_Date", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Date", A_Date);
   if(A_Section == null) Commande.Parameters.AddWithValue("@A_Section", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Section", A_Section);
   if(A_Chef == null) Commande.Parameters.AddWithValue("@A_Chef", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Chef", A_Chef);
   if(A_Chef2 == null) Commande.Parameters.AddWithValue("@A_Chef2", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Chef2", A_Chef2);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Id_Activite"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Id_Activite, string A_Nom, DateTime? A_Date, int? A_Section, int? A_Chef, int? A_Chef2)
  {
   CreerCommande("ModifierT_Activite");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Activite", Id_Activite);
   if(A_Nom == null) Commande.Parameters.AddWithValue("@A_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Nom", A_Nom);
   if(A_Date == null) Commande.Parameters.AddWithValue("@A_Date", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Date", A_Date);
   if(A_Section == null) Commande.Parameters.AddWithValue("@A_Section", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Section", A_Section);
   if(A_Chef == null) Commande.Parameters.AddWithValue("@A_Chef", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Chef", A_Section);
   if(A_Chef2 == null) Commande.Parameters.AddWithValue("@A_Chef2", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@A_Chef2", A_Section);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Activite> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Activite");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Activite> res = new List<C_T_Activite>();
   while (dr.Read())
   {
    C_T_Activite tmp = new C_T_Activite();
    tmp.Id_Activite = int.Parse(dr["Id_Activite"].ToString());
    tmp.A_Nom = dr["A_Nom"].ToString();
   if(dr["A_Date"] != DBNull.Value) tmp.A_Date = DateTime.Parse(dr["A_Date"].ToString());
   if(dr["A_Section"] != DBNull.Value) tmp.A_Section = int.Parse(dr["A_Section"].ToString());
   if(dr["A_Chef"] != DBNull.Value) tmp.A_Chef = int.Parse(dr["A_Chef"].ToString());
   if(dr["A_Chef2"] != DBNull.Value) tmp.A_Chef2 = int.Parse(dr["A_Chef2"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Activite Lire_ID(int Id_Activite)
  {
   CreerCommande("SelectionnerT_Activite_ID");
   Commande.Parameters.AddWithValue("@Id_Activite", Id_Activite);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Activite res = new C_T_Activite();
   while (dr.Read())
   {
    res.Id_Activite = int.Parse(dr["Id_Activite"].ToString());
    res.A_Nom = dr["A_Nom"].ToString();
   if(dr["A_Date"] != DBNull.Value) res.A_Date = DateTime.Parse(dr["A_Date"].ToString());
   if(dr["A_Section"] != DBNull.Value) res.A_Section = int.Parse(dr["A_Section"].ToString());
   if(dr["A_Chef"] != DBNull.Value) res.A_Chef = int.Parse(dr["A_Chef"].ToString());
   if(dr["A_Chef2"] != DBNull.Value) res.A_Chef2 = int.Parse(dr["A_Chef2"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Id_Activite)
  {
   CreerCommande("SupprimerT_Activite");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Activite", Id_Activite);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
