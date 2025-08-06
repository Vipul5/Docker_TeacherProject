CREATE TABLE IF NOT EXISTS "Teachers" (
    "Id" SERIAL PRIMARY KEY,
    "FirstName" VARCHAR(100) NOT NULL,
    "LastName" VARCHAR(100) NOT NULL,
    "Subject" VARCHAR(100),
    "Email" VARCHAR(100) UNIQUE
);

INSERT INTO "Teachers" ("FirstName", "LastName", "Subject", "Email") VALUES
('Sachin', 'Tendulkar', 'Mathematics', 'Sachin.Tendulkar@example.com'),
('Sourav', 'Ganguly', 'Physics', 'Sourav.Ganguly@example.com'),
('Rahul', 'Dravid', 'Chemistry', 'Rahul.Dravid@example.com'),
('Yuvraj', 'Singh', 'History', 'Yuvraj.Singh@example.com'),
('Suresh', 'Raina', 'English', 'Suresh.Raina@example.com');