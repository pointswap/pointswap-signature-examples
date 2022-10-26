package main

import (
	"crypto/hmac"
	"crypto/sha512"
	"fmt"
)

func main() {
	secret := "NhqPtmdSJYdKjVHjA7PZj4Mge3R5YNiP1e3UZjInClVN65XAbvqqM6A7H5fATj0j"

	query_string := "timestamp=1578963600000"
	fmt.Println("hashing the string:")
	fmt.Println(query_string)
	fmt.Println("and return:")
	fmt.Println(signature(query_string, secret))
	fmt.Println("")

	query_string = "platform_id=some_platform0&brand_id=1234&brand_member_id=5678&timestamp=1578963600000"
	fmt.Println("hashing the string: ")
	fmt.Println(query_string)
	fmt.Println("and return:")
	fmt.Println(signature(query_string, secret))
	fmt.Println("")
}

func signature(message, secret string) string {
	mac := hmac.New(sha512.New, []byte(secret))
	mac.Write([]byte(message))
	signingKey := fmt.Sprintf("%x", mac.Sum(nil))
	return signingKey
}
