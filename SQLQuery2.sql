--insert 
--Low season rates
INSERT INTO Rate (SeasonID, RoomID, RatePerNight, EffectiveDate)
SELECT 1, RoomID, 550.00, '2025-12-01' FROM Room;

--Mid season rates
INSERT INTO Rate (SeasonID, RoomID, RatePerNight, EffectiveDate)
SELECT 2, RoomID, 750.00, '2025-12-08' FROM Room;

--high season rates
INSERT INTO Rate (SeasonID, RoomID, RatePerNight, EffectiveDate)
SELECT 3, RoomID, 995.00, '2025-12-16' FROM Room;

--Test data spcifics
--guests
INSERT INTO Guest (FirstName, LastName, Address, City, PostalCode, PhoneNumber, Email, IDPassportNumber) VALUES
('John', 'Smith', '7 Main Rd, Rondebosch', 'Cape Town', '7700', '0211234567', 'john.smith@email.com', 'ID7801015800081'),
('Nkosinathi', 'Mthembu', '14 Lungelo Drive, Mtimkhulu', 'Durban', '4001', '0312345678', 'nkosinathi.m@email.com', 'ID8305125900082'),
('Sarah', 'Johnson', '45 Beach Road', 'Durban', '4001', '0318765432', 'sarah.j@email.com', 'ID9012203400083'),
('Michael', 'Williams', '12 Park Avenue', 'Johannesburg', '2001', '0117654321', 'michael.w@email.com', 'ID7509158000084'),
('Thandi', 'Dlamini', '89 Nelson Mandela Drive', 'Pretoria', '0002', '0129876543', 'thandi.d@email.com', 'ID8712114200085'),
('David', 'Brown', '23 Sea View Crescent', 'Port Elizabeth', '6001', '0415556789', 'david.b@email.com', 'ID8206097800086'),
('Linda', 'van der Merwe', '56 Mountain Road', 'Cape Town', '7708', '0214445678', 'linda.vdm@email.com', 'ID9101258000087'),
('Sipho', 'Khumalo', '78 Victoria Street', 'East London', '5201', '0437778899', 'sipho.k@email.com', 'ID7808213400088'),
('Emma', 'Taylor', '34 Ocean Drive', 'Cape Town', '7945', '0215554433', 'emma.t@email.com', 'ID8904182200089'),
('Zanele', 'Ndlovu', '91 Garden Lane', 'Bloemfontein', '9301', '0513332211', 'zanele.n@email.com', 'ID9206245800090');

--bookings
INSERT INTO Booking (GuestID, RoomID, BookingReference, CheckInDate, CheckOutDate, NumberOfGuests, NumberOfNights, TotalAmount, DepositAmount, BookingStatus)
VALUES (1, 1, 'BK2025001', '2025-12-25', '2025-12-26', 2, 1, 995.00, 99.50, 'Confirmed');

INSERT INTO Booking (GuestID, RoomID, BookingReference, CheckInDate, CheckOutDate, NumberOfGuests, NumberOfNights, TotalAmount, DepositAmount, BookingStatus)
VALUES 
(3, 2, 'BK2025002', '2025-12-25', '2025-12-26', 2, 1, 995.00, 99.50, 'Confirmed'),--fully booked 
(4, 3, 'BK2025003', '2025-12-25', '2025-12-26', 3, 1, 995.00, 99.50, 'Confirmed'),
(5, 4, 'BK2025004', '2025-12-25', '2025-12-26', 2, 1, 995.00, 99.50, 'Confirmed'),
(6, 5, 'BK2025005', '2025-12-25', '2025-12-26', 4, 1, 995.00, 99.50, 'Confirmed');

INSERT INTO Booking (GuestID, RoomID, BookingReference, CheckInDate, CheckOutDate, NumberOfGuests, NumberOfNights, TotalAmount, DepositAmount, BookingStatus)
VALUES 
(7, 1, 'BK2025006', '2025-12-27', '2025-12-28', 2, 1, 995.00, 99.50, 'Confirmed'),--1 room available for 27th-28th
(8, 2, 'BK2025007', '2025-12-27', '2025-12-28', 2, 1, 995.00, 99.50, 'Confirmed'),
(9, 3, 'BK2025008', '2025-12-27', '2025-12-28', 3, 1, 995.00, 99.50, 'Confirmed'),
(10, 4, 'BK2025009', '2025-12-27', '2025-12-28', 2, 1, 995.00, 99.50, 'Confirmed');

INSERT INTO Booking (GuestID, RoomID, BookingReference, CheckInDate, CheckOutDate, NumberOfGuests, NumberOfNights, TotalAmount, DepositAmount, BookingStatus)
VALUES 
(3, 1, 'BK2025010', '2025-12-24', '2025-12-25', 2, 1, 995.00, 99.50, 'Confirmed'),--3 rooms available on 24th
(4, 2, 'BK2025011', '2025-12-24', '2025-12-25', 2, 1, 995.00, 99.50, 'Confirmed');

INSERT INTO Booking (GuestID, RoomID, BookingReference, CheckInDate, CheckOutDate, NumberOfGuests, NumberOfNights, TotalAmount, DepositAmount, BookingStatus)
VALUES (5, 3, 'BK2025012', '2025-12-20', '2025-12-23', 2, 3, 2985.00, 298.50, 'Confirmed'); --additional 

--guest accounts
INSERT INTO Guest_Account (GuestID, BookingID, TotalCharges, TotalPayments, Balance)
SELECT GuestID, BookingID, TotalAmount, DepositAmount, (TotalAmount - DepositAmount)
FROM Booking;

--payments
INSERT INTO Payment (BookingID, AccountID, PaymentAmount, PaymentMethod, CardNumber, PaymentStatus)
SELECT BookingID, AccountID, DepositAmount, 'Credit Card', '****1234', 'Completed'
FROM Booking B
INNER JOIN Guest_Account GA ON B.BookingID = GA.BookingID;
