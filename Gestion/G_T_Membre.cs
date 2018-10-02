#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_DB_SCOUT.Classes;
using Projet_DB_SCOUT.Acces;
#endregion

namespace Projet_DB_SCOUT.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_T_Membre : G_Base
 {
  #region Constructeurs
  public G_T_Membre()
   : base()
  { }
  public G_T_Membre(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string M_Nom, string M_Prenom, int M_Age, string M_Sexe, string M_Statut, string M_Section, string M_Cotisation, string M_Mail)
  { return new A_T_Membre(ChaineConnexion).Ajouter(M_Nom, M_Prenom, M_Age, M_Sexe, M_Statut, M_Section, M_Cotisation, M_Mail); }
  public int Modifier(int Id_Membre, string M_Nom, string M_Prenom, int M_Age, string M_Sexe, string M_Statut, string M_Section, string M_Cotisation, string M_Mail)
  { return new A_T_Membre(ChaineConnexion).Modifier(Id_Membre, M_Nom, M_Prenom, M_Age, M_Sexe, M_Statut, M_Section, M_Cotisation, M_Mail); }
  public List<C_T_Membre> Lire(string Index)
  { return new A_T_Membre(ChaineConnexion).Lire(Index); }
  public C_T_Membre Lire_ID(int Id_Membre)
  { return new A_T_Membre(ChaineConnexion).Lire_ID(Id_Membre); }
  public int Supprimer(int Id_Membre)
  { return new A_T_Membre(ChaineConnexion).Supprimer(Id_Membre); }
 }
}
