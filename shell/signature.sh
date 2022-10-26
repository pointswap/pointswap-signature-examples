#!/usr/bin/env bash

SECRET="NhqPtmdSJYdKjVHjA7PZj4Mge3R5YNiP1e3UZjInClVN65XAbvqqM6A7H5fATj0j"

QUERY_STRING="timestamp=1578963600000"

echo "hashing string"
echo $QUERY_STRING
echo "and return"
printf $QUERY_STRING | \
openssl dgst -sha512 -hmac $SECRET
# should produce "032533652b72f107764581db69dfebe130b80f2d1d4166e996da7be07299b797d615238abc46f13ed5be2d0a67c101b16fa13c41e5b94d3468018bd0295f206c"

printf "\n"

QUERY_STRING="platform_id=some_platform0&brand_id=1234&brand_member_id=5678&timestamp=1578963600000"

echo "hashing string"
echo $QUERY_STRING
echo "and return"
printf $QUERY_STRING | \
openssl dgst -sha512 -hmac $SECRET
# should produce "0ac8923e7f6b1cdd1a44e8d01abed4c55ca897e6753d0ccf75d254000621e149bb35f8c468dbaeb60493a986a454563dda772bd7b2cf25a56d000c81cf820bdd"
