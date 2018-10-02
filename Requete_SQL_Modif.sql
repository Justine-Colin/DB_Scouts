USE [C:\USERS\JUJU_\SOURCE\REPOS\DB_SCOUT.MDF]
go
WITH bb(cpt,chf)
as
(SELECT COUNT(Id_Activite) AS cc, A_Chef2 FROM T_Activite GROUP BY A_Chef2 UNION
SELECT COUNT(Id_Activite) as cc, A_Chef as A_Chef2 FROM T_Activite GROUP BY A_Chef)

select sum(cpt),chf from bb group by chf