/*
   Швиденко Дмитро Юрійович (ІШІ-501)

   task:
   Скласти список імен всіх клієнтів, які вже оглянули хоча б один об'єкт,
   що здається в оренду, і повідомили свою думку з цього приводу.

*/

SELECT DISTINCT Renter.FName, Renter.LName
FROM Renter
JOIN Viewing ON Renter.Rno = Viewing.Rno
JOIN Property_for_Rent ON Viewing.Pno = Property_for_Rent.Sno;