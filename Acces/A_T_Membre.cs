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
 public class A_T_Membre : ADBase
 {
  #region Constructeurs
  public A_T_Membre(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string M_Nom, string M_Prenom, int M_Age, string M_Sexe, string M_Statut, string M_Section, string M_Cotisation, string M_Mail)
  {
   CreerCommande("AjouterT_Membre");
   int res = 0;
   Commande.Parameters.Add("Id_Membre", SqlDbType.Int);
   Direction("Id_Membre", ParameterDirection.Output);
   if(M_Nom == null) Commande.Parameters.AddWithValue("@M_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Nom", M_Nom);
   if(M_Prenom == null) Commande.Parameters.AddWithValue("@M_Prenom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Prenom", M_Prenom);
   Commande.Parameters.AddWithValue("@M_Age", M_Age);
   if(M_Sexe == null) Commande.Parameters.AddWithValue("@M_Sexe", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Sexe", M_Sexe);
   if(M_Statut == null) Commande.Parameters.AddWithValue("@M_Statut", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Statut", M_Statut);
   if(M_Section == null) Commande.Parameters.AddWithValue("@M_Section", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Section", M_Section);
   if(M_Cotisation == null) Commande.Parameters.AddWithValue("@M_Cotisation", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Cotisation", M_Cotisation);
            if (M_Mail == null) Commande.Parameters.AddWithValue("@M_Mail", Convert.DBNull);
            else Commande.Parameters.AddWithValue("@M_Mail", M_Mail);
            Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Id_Membre"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Id_Membre, string M_Nom, string M_Prenom, int M_Age, string M_Sexe, string M_Statut, string M_Section, string M_Cotisation, string M_Mail)
  {
   CreerCommande("ModifierT_Membre");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Membre", Id_Membre);
   if(M_Nom == null) Commande.Parameters.AddWithValue("@M_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Nom", M_Nom);
   if(M_Prenom == null) Commande.Parameters.AddWithValue("@M_Prenom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Prenom", M_Prenom);
   Commande.Parameters.AddWithValue("@M_Age", M_Age);
   if(M_Sexe == null) Commande.Parameters.AddWithValue("@M_Sexe", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Sexe", M_Sexe);
   if(M_Statut == null) Commande.Parameters.AddWithValue("@M_Statut", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Statut", M_Statut);
   if(M_Section == null) Commande.Parameters.AddWithValue("@M_Section", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Section", M_Section);
   if(M_Cotisation == null) Commande.Parameters.AddWithValue("@M_Cotisation", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@M_Cotisation", M_Cotisation);
            if (M_Mail == null) Commande.Parameters.AddWithValue("@M_Mail", Convert.DBNull);
            else Commande.Parameters.AddWithValue("@M_Mail", M_Mail);
            Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_T_Membre> Lire(string Index)
  {
   CreerCommande("SelectionnerT_Membre");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_T_Membre> res = new List<C_T_Membre>();
   while (dr.Read())
   {
    C_T_Membre tmp = new C_T_Membre();
    tmp.Id_Membre = int.Parse(dr["Id_Membre"].ToString());
    tmp.M_Nom = dr["M_Nom"].ToString();
    tmp.M_Prenom = dr["M_Prenom"].ToString();
    tmp.M_Age = int.Parse(dr["M_Age"].ToString());
    tmp.M_Sexe = dr["M_Sexe"].ToString();
    tmp.M_Statut = dr["M_Statut"].ToString();
    tmp.M_Section = dr["M_Section"].ToString();
    tmp.M_Cotisation = dr["M_Cotisation"].ToString();
                tmp.M_Mail = dr["M_Mail"].ToString();
                res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_T_Membre Lire_ID(int Id_Membre)
  {
   CreerCommande("SelectionnerT_Membre_ID");
   Commande.Parameters.AddWithValue("@Id_Membre", Id_Membre);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_T_Membre res = new C_T_Membre();
   while (dr.Read())
   {
    res.Id_Membre = int.Parse(dr["Id_Membre"].ToString());
    res.M_Nom = dr["M_Nom"].ToString();
    res.M_Prenom = dr["M_Prenom"].ToString();
    res.M_Age = int.Parse(dr["M_Age"].ToString());
    res.M_Sexe = dr["M_Sexe"].ToString();
    res.M_Statut = dr["M_Statut"].ToString();
    res.M_Section = dr["M_Section"].ToString();
    res.M_Cotisation = dr["M_Cotisation"].ToString();
                res.M_Mail = dr["M_Mail"].ToString();
            }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Id_Membre)
  {
   CreerCommande("SupprimerT_Membre");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_Membre", Id_Membre);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
