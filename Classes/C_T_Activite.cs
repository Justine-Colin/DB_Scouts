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
 public class C_T_Activite
 {
  #region Données membres
  private int _Id_Activite;
  private string _A_Nom;
  private DateTime? _A_Date;
  private int? _A_Section;
  private int? _A_Chef;
  private int? _A_Chef2;
  #endregion
  #region Constructeurs
  public C_T_Activite()
  { }
  public C_T_Activite(string A_Nom_, DateTime? A_Date_, int? A_Section_, int? A_Chef_, int? A_Chef2_)
  {
   A_Nom = A_Nom_;
   A_Date = A_Date_;
   A_Section = A_Section_;
   A_Chef = A_Chef_;
   A_Chef2 = A_Chef2_;

  }
  public C_T_Activite(int Id_Activite_, string A_Nom_, DateTime? A_Date_, int? A_Section_, int? A_Chef_, int? A_Chef2_)
   : this(A_Nom_, A_Date_, A_Section_, A_Chef_, A_Chef2_)
  {
   Id_Activite = Id_Activite_;
  }
  #endregion
  #region Accesseurs
  public int Id_Activite
  {
   get { return _Id_Activite; }
   set { _Id_Activite = value; }
  }
  public string A_Nom
  {
   get { return _A_Nom; }
   set { _A_Nom = value; }
  }
  
  public DateTime? A_Date
  {
   get { return _A_Date; }
   set { _A_Date = value; }
  }
  
  public int? A_Section
  {
   get { return _A_Section; }
   set { _A_Section = value; }
  }

  public int? A_Chef
  {
   get { return _A_Chef; }
   set { _A_Chef = value; }
  }

  public int? A_Chef2
  {
   get { return _A_Chef2; }
   set { _A_Chef2 = value; }
  }
  #endregion
 }
}
