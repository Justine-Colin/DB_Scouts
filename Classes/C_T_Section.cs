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
 public class C_T_Section
 {
  #region Données membres
  private int _Id_Section;
  private string _S_Nom;
  private int? _S_Age_Min;
  private int? _S_Age_Max;
  private string _S_Sexe;
  private bool _S_Complet;
  #endregion
  #region Constructeurs
  public C_T_Section()
  { }
  public C_T_Section(string S_Nom_, int? S_Age_Min_, int? S_Age_Max_, string S_Sexe_, bool S_Complet_)
  {
   S_Nom = S_Nom_;
   S_Age_Min = S_Age_Min_;
   S_Age_Max = S_Age_Max_;
   S_Sexe = S_Sexe_;
   S_Complet = S_Complet_;
  }
  public C_T_Section(int Id_Section_, string S_Nom_, int? S_Age_Min_, int? S_Age_Max_, string S_Sexe_, bool S_Complet_)
   : this(S_Nom_, S_Age_Min_, S_Age_Max_, S_Sexe_, S_Complet_)
  {
   Id_Section = Id_Section_;
  }
  #endregion
  #region Accesseurs
  public int Id_Section
  {
   get { return _Id_Section; }
   set { _Id_Section = value; }
  }
  public string S_Nom
  {
   get { return _S_Nom; }
   set { _S_Nom = value; }
  }
  public int? S_Age_Min
  {
   get { return _S_Age_Min; }
   set { _S_Age_Min = value; }
  }
  public int? S_Age_Max
  {
   get { return _S_Age_Max; }
   set { _S_Age_Max = value; }
  }
  public string S_Sexe
  {
   get { return _S_Sexe; }
   set { _S_Sexe = value; }
  }
  public bool S_Complet
  {
   get { return _S_Complet; }
   set { _S_Complet = value; }
  }
  #endregion
 }
}
