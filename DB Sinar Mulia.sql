---TABEL PETANI
create TABLE Petani (
id_petani Serial PRIMARY KEY,
Username VARCHAR(100),
Password VARCHAR(100),
No_Telephone Integer
);

--TABEL OPERATOR
create TABLE Operator (
id_Operator Serial PRIMARY KEY,
Username VARCHAR(100),
Password VARCHAR(100)
);

--TABEL ALAMAT
CREATE TABLE ALAMAT(
id_Alamat Serial PRIMARY KEY,
Jalan VARCHAR(100),
RT integer,
RW integer,
Blok Integer
);

--TABEL STATUS
CREATE TABLE Status(
id_status Serial PRIMARY KEY,
Status VARCHAR(100)
);

--TABEL PERMINTAAN IRIGASI
create TABLE Permintaan_Irigasi (
id_Permintaan Serial PRIMARY KEY,
Luas_Lahan INTEGER,
Tanggal_Pengairan Integer,
Durasi_Pengairan INTERVAL,
id_petani INTEGER,
id_Operator INTEGER,
id_Alamat INTEGER,
id_status INTEGER,
FOREIGN KEY (id_petani) REFERENCES petani(id_petani),
FOREIGN KEY (id_Operator) REFERENCES Operator(id_Operator),
FOREIGN KEY (id_Alamat) REFERENCES Alamat(id_Alamat),
FOREIGN KEY (id_status) REFERENCES Status(id_Status)
);

