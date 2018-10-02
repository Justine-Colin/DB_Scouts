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
 public class C_T_Liaison_C
 {
  #region Données membres
  private int _Id_Liaison_C;
  private int? _Id_Activite;
  private int? _Id_Chef1;
  private int? _Id_Chef2;
  #endregion
  #region Constructeurs
  public C_T_Liaison_C()
  { }
  public C_T_Liaison_C(int? Id_Activite_, int? Id_Chef1_, int? Id_Chef2_)
  {
   Id_Activite = Id_Activite_;
   Id_Chef1 = Id_Chef1_;
   Id_Chef2 = Id_Chef2_;
  }
  public C_T_Liaison_C(int Id_Liaison_C_, int? Id_Activite_, int? Id_Chef1_, int? Id_Chef2_)
   : this(Id_Activite_, Id_Chef1_, Id_Chef2_)
  {
   Id_Liaison_C = Id_Liaison_C_;
  }
  #endregion
  #region Accesseurs
  public int Id_Liaison_C
  {
   get { return _Id_Liaison_C; }
   set { _Id_Liaison_C = value; }
  }
  public int? Id_Activite
  {
   get { return _Id_Activite; }
   set { _Id_Activite = value; }
  }
  public int? Id_Chef1
  {
   get { return _Id_Chef1; }
   set { _Id_Chef1 = value; }
  }
  public int? Id_Chef2
  {
   get { return _Id_Chef2; }
   set { _Id_Chef2 = value; }
  }
  #endregion
 }
}
