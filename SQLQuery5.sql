SELECT Users.firstName, Users.LastName, Tickets.description, Tickets.date
FROM Users JOIN Tickets
ON Users.userID = Tickets.userID
WHERE Tickets.userID = 3