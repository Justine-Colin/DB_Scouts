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
 public class G_T_Activite : G_Base
 {
  #region Constructeurs
  public G_T_Activite()
   : base()
  { }
  public G_T_Activite(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string A_Nom, DateTime? A_Date, int? A_Section, int? A_Chef, int? A_Chef2)
  { return new A_T_Activite(ChaineConnexion).Ajouter(A_Nom, A_Date, A_Section, A_Chef, A_Chef2); }
  public int Modifier(int Id_Activite, string A_Nom, DateTime? A_Date, int? A_Section, int? A_Chef, int? A_Chef2)
  { return new A_T_Activite(ChaineConnexion).Modifier(Id_Activite, A_Nom, A_Date, A_Section, A_Chef, A_Chef2); }
  public List<C_T_Activite> Lire(string Index)
  { return new A_T_Activite(ChaineConnexion).Lire(Index); }
  public C_T_Activite Lire_ID(int Id_Activite)
  { return new A_T_Activite(ChaineConnexion).Lire_ID(Id_Activite); }
  public int Supprimer(int Id_Activite)
  { return new A_T_Activite(ChaineConnexion).Supprimer(Id_Activite); }
 }
}
