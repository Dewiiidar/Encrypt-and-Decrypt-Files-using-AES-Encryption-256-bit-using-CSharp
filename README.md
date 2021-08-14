# Encrypt-and-Decrypt-Files-using-AES-Encryption-256-bit-using-CSharp
We have 3 main functions,
The first: GenerateRandomSalt()
          Generate a random salt that will be used to generate the Encryption key.

The Second: FileEncrypt(string inputFile, string password)
            The Encryption function that takes the input file and password as a parameters,
            First we create the output file .aes ,
            then we Generate a random salt and use this salt with the password sent to the function with a number of iterations to Generate the Encryption key.
             we Assign the key to the AES and select AES mode "CFB" that allow the block encryptor to be used as a stream cipher.
            then we write the generated salt to the begining of the output file, so in this case can be random every time,
            now we use "AES.CreateEncryptor()" to encrypt our file stream , then we copy the input file to the output file.

The Third:  FileDecrypt(string inputFile, string outputFile, string password)
            The Decryption function that takes the Encrypted file path and the path for decrypted file and the password,
            first we read the inserted random salt from the Encrypted file, then we generate the key using this salt and the password and the same number of iterations used in the Encryption function.
            we Assign the key to the AES and select AES mode "CFB",
            then we use "AES.CreateDecryptor()" to decrypt our file stream. then we create our output file and  write the Decrypted stream on it .
