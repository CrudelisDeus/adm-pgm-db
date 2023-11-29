/*
   Швиденко Дмитро Юрійович (ІШІ-501)

   task:
   Перелічити відділення компанії і об'єкти,
   що здаються в оренду, які розташовані в одному
   і тому ж місті, а також всі інші об'єкти.

*/

SELECT
    s.City AS DepartmentCity,
    r.Address AS PropertyAddress
FROM
    Staff s
LEFT JOIN
    Property_for_Rent r ON s.Bno = r.Bno
WHERE
    s.City = r.City OR r.City IS NULL;