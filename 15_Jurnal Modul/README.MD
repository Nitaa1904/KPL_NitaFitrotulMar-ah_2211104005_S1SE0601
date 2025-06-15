# User Registration and Login System (Windows Forms)

## Deskripsi

Sistem ini merupakan aplikasi Windows Forms yang menyediakan fitur **registrasi** dan **login** untuk pengguna. Seluruh proses dirancang dengan memperhatikan aspek keamanan dan validasi data.

## Fitur

- **Registrasi Pengguna**

  - _Username_ hanya boleh terdiri dari huruf alfabet.
  - _Password_ harus:

    - Panjang 8–20 karakter
    - Mengandung setidaknya satu angka
    - Memuat karakter khusus seperti `!@#$%^&*`
    - Tidak terlalu mirip dengan _username_

  - Validasi ketat pada _username_ dan _password_. Jika ada syarat yang tidak terpenuhi, sistem menampilkan pesan kesalahan yang informatif.
  - _Password_ yang valid akan di-_hash_ menggunakan algoritma **SHA256** sebelum disimpan.

- **Login Pengguna**

  - Verifikasi kredensial dilakukan dengan mencocokkan _hash_ dari _password_ yang diinput pengguna dengan _hash_ yang tersimpan.
  - Login berhasil jika _hash_ cocok, sebaliknya akan muncul pesan kesalahan jika tidak cocok.

## Struktur Data

Data pengguna disimpan dalam format berikut (didefinisikan pada file `User.cs`):

- `Username`
- `Password` (sudah dalam bentuk _hash_)

## File Terkait

- `FormRegister.cs` — Menangani proses registrasi dan validasi akun baru.
- `FormLogin.cs` — Menangani proses login dan verifikasi kredensial pengguna.
- `User.cs` — Mendefinisikan struktur data pengguna.

## Keamanan

- _Password_ disimpan dalam bentuk _hash_ menggunakan **SHA256** untuk mencegah penyalahgunaan data.
- Validasi input mencegah penggunaan data yang lemah atau mudah ditebak.
