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
 public class G_T_Section : G_Base
 {
  #region Constructeurs
  public G_T_Section()
   : base()
  { }
  public G_T_Section(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string S_Nom, int? S_Age_Min, int? S_Age_Max, string S_Sexe, bool S_Complet)
  { return new A_T_Section(ChaineConnexion).Ajouter(S_Nom, S_Age_Min, S_Age_Max, S_Sexe, S_Complet); }
  public int Modifier(int Id_Section, string S_Nom, int? S_Age_Min, int? S_Age_Max, string S_Sexe, bool S_Complet)
  { return new A_T_Section(ChaineConnexion).Modifier(Id_Section, S_Nom, S_Age_Min, S_Age_Max, S_Sexe, S_Complet); }
  public List<C_T_Section> Lire(string Index)
  { return new A_T_Section(ChaineConnexion).Lire(Index); }
  public C_T_Section Lire_ID(int Id_Section)
  { return new A_T_Section(ChaineConnexion).Lire_ID(Id_Section); }
  public int Supprimer(int Id_Section)
  { return new A_T_Section(ChaineConnexion).Supprimer(Id_Section); }
 }
}
