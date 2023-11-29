/*
   Швиденко Дмитро Юрійович (ІШІ-501)

   task:
   Перелічити відділення компанії і об'єкти, що здаються в оренду,
   розташовані в одному і тому ж місті, а також всі інші відділення і об'єкти.

*/

SELECT
    s.Bno,
    s.City AS DepartmentCity,
    r.Sno,
    r.Address AS PropertyAddress
FROM
    Staff s
LEFT JOIN
    Property_for_Rent r ON s.Bno = r.Bno;