#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_DB_SCOUT.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_T_Liaison_G
 {
  #region Données membres
  private int _Id_Liaison_G;
  private int? _Id_Activite;
  private int? _Id_Anime;
  #endregion
  #region Constructeurs
  public C_T_Liaison_G()
  { }
  public C_T_Liaison_G(int? Id_Activite_, int? Id_Anime_)
  {
   Id_Activite = Id_Activite_;
   Id_Anime = Id_Anime_;
  }
  public C_T_Liaison_G(int Id_Liaison_G_, int? Id_Activite_, int? Id_Anime_)
   : this(Id_Activite_, Id_Anime_)
  {
   Id_Liaison_G = Id_Liaison_G_;
  }
  #endregion
  #region Accesseurs
  public int Id_Liaison_G
  {
   get { return _Id_Liaison_G; }
   set { _Id_Liaison_G = value; }
  }
  public int? Id_Activite
  {
   get { return _Id_Activite; }
   set { _Id_Activite = value; }
  }
  public int? Id_Anime
  {
   get { return _Id_Anime; }
   set { _Id_Anime = value; }
  }
  #endregion
 }
}
