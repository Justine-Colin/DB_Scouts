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
 public class C_T_Membre
 {
  #region Données membres
  private int _Id_Membre;
  private string _M_Nom;
  private string _M_Prenom;
  private int _M_Age;
  private string _M_Sexe;
  private string _M_Statut;
  private string _M_Section;
  private string _M_Cotisation;
        private string _M_Mail;
  #endregion
  #region Constructeurs
  public C_T_Membre()
  { }
  public C_T_Membre(string M_Nom_, string M_Prenom_, int M_Age_, string M_Sexe_, string M_Statut_, string M_Section_, string M_Cotisation_, string M_Mail_)
  {
   M_Nom = M_Nom_;
   M_Prenom = M_Prenom_;
   M_Age = M_Age_;
   M_Sexe = M_Sexe_;
   M_Statut = M_Statut_;
   M_Section = M_Section_;
   M_Cotisation = M_Cotisation_;
            M_Mail = M_Mail_;
  }
  public C_T_Membre(int Id_Membre_, string M_Nom_, string M_Prenom_, int M_Age_, string M_Sexe_, string M_Statut_, string M_Section_, string M_Cotisation_, string M_Mail_)
   : this(M_Nom_, M_Prenom_, M_Age_, M_Sexe_, M_Statut_, M_Section_, M_Cotisation_, M_Mail_)
  {
   Id_Membre = Id_Membre_;
  }
  #endregion
  #region Accesseurs
  public int Id_Membre
  {
   get { return _Id_Membre; }
   set { _Id_Membre = value; }
  }
  public string M_Nom
  {
   get { return _M_Nom; }
   set { _M_Nom = value; }
  }
  public string M_Prenom
  {
   get { return _M_Prenom; }
   set { _M_Prenom = value; }
  }
  public int M_Age
  {
   get { return _M_Age; }
   set { _M_Age = value; }
  }
  public string M_Sexe
  {
   get { return _M_Sexe; }
   set { _M_Sexe = value; }
  }
  public string M_Statut
  {
   get { return _M_Statut; }
   set { _M_Statut = value; }
  }
  public string M_Section
  {
   get { return _M_Section; }
   set { _M_Section = value; }
  }
  public string M_Cotisation
  {
   get { return _M_Cotisation; }
   set { _M_Cotisation = value; }
  }

        public string M_Mail
        {
            get { return _M_Mail; }
            set { _M_Mail = value; }
        }
        #endregion
    }
}
