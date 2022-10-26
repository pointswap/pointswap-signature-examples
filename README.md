# PointSwap Request Signature Example Code

* PointSwap partner API endpoints require a signature parameter to be sent in the query string
* The signature algorithm is HMAC-SHA256. Use your API secret as the key and the request query string concatenated with the request body as the value
