USE master;
create database tunaDB;
DROP DATABASE tunaDB;

use tunaDB;
select * from FishInformation

CREATE TABLE FishInformation (
    FishNumber NVARCHAR(50) PRIMARY KEY,            -- Khóa chính, không trùng lặp và không rỗng
    GRNNumber NVARCHAR(50) NOT NULL,                -- Không được để trống
    CatchingMethod NVARCHAR(50) NOT NULL,           -- Không được để trống
    CatchArea NVARCHAR(100) NOT NULL,               -- Không được để trống
    ReceivingDate DATETIME NOT NULL,                -- Không được để trống
    CatchDate DATETIME NOT NULL,                    -- Không được để trống
    Species NVARCHAR(100) NOT NULL,                 -- Không được để trống
    CollectedBy NVARCHAR(100) NOT NULL,             -- Không được để trống
    ReceivedFor NVARCHAR(100) NOT NULL,             -- Không được để trống
    NIC NVARCHAR(20) CHECK(LEN(NIC) = 9),           -- Ràng buộc độ dài, ví dụ: NIC có 9 ký tự
    Grade NVARCHAR(10),                             -- Có thể để trống, ví dụ rỗng nếu không có thông tin
    Vessel NVARCHAR(100) NOT NULL,                  -- Không được để trống
    DhoniCode NVARCHAR(20) NOT NULL,                -- Không được để trống
    Weight DECIMAL(18, 2) CHECK(Weight > 0)         -- Ràng buộc giá trị phải lớn hơn 0
);

INSERT INTO FishInformation (FishNumber, GRNNumber, CatchingMethod, CatchArea, ReceivingDate, CatchDate, Species, CollectedBy, ReceivedFor, NIC, Grade, Vessel, DhoniCode, Weight)
VALUES 
('F001', 'GRN123456', 'Net', 'Area A', '2024-10-21', '2024-10-20', 'Tuna', 'John Doe', 'Company A', '123456789', 'A', 'Vessel A', 'Dhoni001', 15.5),
('F002', 'GRN123457', 'Line', 'Area B', '2024-10-21', '2024-10-19', 'Salmon', 'Jane Smith', 'Company B', '987654321', 'B', 'Vessel B', 'Dhoni002', 12.0),
('F003', 'GRN123458', 'Trap', 'Area C', '2024-10-21', '2024-10-18', 'Mackerel', 'Alice Johnson', 'Company C', '123456780', 'A', 'Vessel C', 'Dhoni003', 10.25)
('F004', 'GRN123459', 'Net', 'Area D', '2024-10-21', '2024-10-17', 'Others', 'Tom Brown', 'Company D', '123456790', 'A', 'Vessel D', 'Dhoni004', 20.5),
('F005', 'GRN123460', 'Net', 'Area E', '2024-10-21', '2024-10-16', 'Others', 'Jerry White', 'Company E', '987654322', 'B', 'Vessel E', 'Dhoni005', 18.0),
('F006', 'GRN123461', 'Trap', 'Area F', '2024-10-21', '2024-10-15', 'Others', 'Lucy Green', 'Company F', '123456791', 'A', 'Vessel F', 'Dhoni006', 8.75),
('F007', 'GRN123462', 'Net', 'Area G', '2024-10-21', '2024-10-14', 'Others', 'Peter Black', 'Company G', '987654323', 'C', 'Vessel G', 'Dhoni007', 5.0),
('F008', 'GRN123463', 'Line', 'Area H', '2024-10-21', '2024-10-13', 'Others', 'Sara Silver', 'Company H', '123456792', 'A', 'Vessel H', 'Dhoni008', 11.5),
('F009', 'GRN123464', 'Trap', 'Area I', '2024-10-21', '2024-10-12', 'Others', 'Mark Blue', 'Company I', '987654324', 'B', 'Vessel I', 'Dhoni009', 9.3),
('F010', 'GRN123465', 'Net', 'Area J', '2024-10-21', '2024-10-11', 'Others', 'Emily Red', 'Company J', '123456793', 'C', 'Vessel J', 'Dhoni010', 7.8),
('F011', 'GRN123466', 'Line', 'Area K', '2024-10-21', '2024-10-10', 'Others', 'Steve Yellow', 'Company K', '987654325', 'A', 'Vessel K', 'Dhoni011', 14.0),
('F012', 'GRN123467', 'Trap', 'Area L', '2024-10-21', '2024-10-09', 'Others', 'Anna Pink', 'Company L', '123456794', 'B', 'Vessel L', 'Dhoni012', 15.6),
('F013', 'GRN123468', 'Net', 'Area M', '2024-10-21', '2024-10-08', 'Others', 'Dave Gray', 'Company M', '987654326', 'C', 'Vessel M', 'Dhoni013', 3.4);

drop table FishInformation