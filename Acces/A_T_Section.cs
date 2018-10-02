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
 public class A_T_Section : ADBase
 {
  #region Constructeurs
  public A_T_Section(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string S_Nom, int? S_Age_Min, int? S_Age_Max, string S_Sexe, bool S_Complet)
  {
   CreerCommande("AjouterT_Section");
   int res = 0;
   Commande.Parameters.Add("Id_Section", SqlDbType.Int);
   Direction("Id_Section", ParameterDirection.Output);
   if(S_Nom == null) Commande.Parameters.AddWithValue("@S_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@S_Nom", S_Nom);
   Commande.Parameters.AddWithValue("@S_Age_Min", S_Age_Min);
   Commande.Parameters.AddWithValue("@S_Age_Max", S_Age_Max);
   if(S_Sexe == null) Commande.Parameters.AddWithValue("@S_Sexe", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@S_Sexe", S_Sexe);
   Commande.Parameters.AddWithValue("@S_Complet", S_Complet);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Id_Section"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Id_Section, string S_Nom, int? S_Age_Min, int? S_Age_Max, string S_Sexe, bool S_Complet)
  {
   CreerCommande("ModifierT_Section");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Section", Id_Section);
   if(S_Nom == null) Commande.Parameters.AddWithValue("@S_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@S_Nom", S_Nom);
   if(S_Age_Min == null) Commande.Parameters.AddWithValue("@S_Age_Min", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@S_Age_Min", S_Age_Min);
   if(S_Age_Max == null) Commande.Parameters.AddWithValue("@S_Age_Max", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@S_Age_Max", S_Age_Max);
   if(S_Sexe == null) Commande.Parameters.AddWithValue("@S_Sexe", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@S_Sexe", S_Sexe);
   Commande.Parameters.AddWithValue("@S_Complet", S_Complet);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Section> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Section");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Section> res = new List<C_T_Section>();
   while (dr.Read())
   {
    C_T_Section tmp = new C_T_Section();
    tmp.Id_Section = int.Parse(dr["Id_Section"].ToString());
    tmp.S_Nom = dr["S_Nom"].ToString();
   if(dr["S_Age_Min"] != DBNull.Value) tmp.S_Age_Min = int.Parse(dr["S_Age_Min"].ToString());
   if(dr["S_Age_Max"] != DBNull.Value) tmp.S_Age_Max = int.Parse(dr["S_Age_Max"].ToString());
    tmp.S_Sexe = dr["S_Sexe"].ToString();
    tmp.S_Complet = bool.Parse(dr["S_Complet"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Section Lire_ID(int Id_Section)
  {
   CreerCommande("SelectionnerT_Section_ID");
   Commande.Parameters.AddWithValue("@Id_Section", Id_Section);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Section res = new C_T_Section();
   while (dr.Read())
   {
    res.Id_Section = int.Parse(dr["Id_Section"].ToString());
    res.S_Nom = dr["S_Nom"].ToString();
   if(dr["S_Age_Min"] != DBNull.Value) res.S_Age_Min = int.Parse(dr["S_Age_Min"].ToString());
   if(dr["S_Age_Max"] != DBNull.Value) res.S_Age_Max = int.Parse(dr["S_Age_Max"].ToString());
    res.S_Sexe = dr["S_Sexe"].ToString();
    res.S_Complet = bool.Parse(dr["S_Complet"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Id_Section)
  {
   CreerCommande("SupprimerT_Section");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Section", Id_Section);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
