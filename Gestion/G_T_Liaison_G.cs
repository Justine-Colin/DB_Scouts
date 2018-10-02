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
 public class G_T_Liaison_G : G_Base
 {
  #region Constructeurs
  public G_T_Liaison_G()
   : base()
  { }
  public G_T_Liaison_G(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int? Id_Activite, int? Id_Anime)
  { return new A_T_Liaison_G(ChaineConnexion).Ajouter(Id_Activite, Id_Anime); }
  public int Modifier(int Id_Liaison_G, int? Id_Activite, int? Id_Anime)
  { return new A_T_Liaison_G(ChaineConnexion).Modifier(Id_Liaison_G, Id_Activite, Id_Anime); }
  public List<C_T_Liaison_G> Lire(string Index)
  { return new A_T_Liaison_G(ChaineConnexion).Lire(Index); }
  public C_T_Liaison_G Lire_ID(int Id_Liaison_G)
  { return new A_T_Liaison_G(ChaineConnexion).Lire_ID(Id_Liaison_G); }
  public int Supprimer(int Id_Liaison_G)
  { return new A_T_Liaison_G(ChaineConnexion).Supprimer(Id_Liaison_G); }
 }
}
