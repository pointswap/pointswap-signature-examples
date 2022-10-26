import hmac
import hashlib

def signature(query_string):
    return hmac.new(
        secret, query_string.encode('utf-8'), hashlib.sha512
    ).hexdigest()

secret = b'NhqPtmdSJYdKjVHjA7PZj4Mge3R5YNiP1e3UZjInClVN65XAbvqqM6A7H5fATj0j'

query_string = 'timestamp=1578963600000'
print("signature the string: ")
print(query_string)
print("and return:")
print(signature(query_string))
print("\n")

query_string = "platform_id=some_platform0&brand_id=1234&brand_member_id=5678&timestamp=1578963600000"
print("signature the string: ")
print(query_string)
print("and return:")
print(signature(query_string))
