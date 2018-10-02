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
 public class G_T_Liaison_C : G_Base
 {
  #region Constructeurs
  public G_T_Liaison_C()
   : base()
  { }
  public G_T_Liaison_C(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? Id_Activite, int? Id_Chef1, int? Id_Chef2)
  { return new A_T_Liaison_C(ChaineConnexion).Ajouter(Id_Activite, Id_Chef1, Id_Chef2); }
  public int Modifier(int Id_Liaison_C, int? Id_Activite, int? Id_Chef1, int? Id_Chef2)
  { return new A_T_Liaison_C(ChaineConnexion).Modifier(Id_Liaison_C, Id_Activite, Id_Chef1, Id_Chef2); }
  public List<C_T_Liaison_C> Lire(string Index)
  { return new A_T_Liaison_C(ChaineConnexion).Lire(Index); }
  public C_T_Liaison_C Lire_ID(int Id_Liaison_C)
  { return new A_T_Liaison_C(ChaineConnexion).Lire_ID(Id_Liaison_C); }
  public int Supprimer(int Id_Liaison_C)
  { return new A_T_Liaison_C(ChaineConnexion).Supprimer(Id_Liaison_C); }
 }
}
