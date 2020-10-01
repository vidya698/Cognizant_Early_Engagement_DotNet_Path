Review of delivery partner based on rating



Write a query to display partner id,partner name and review of the delivery partner, give alias name for partner review as 'REVIEW', sort the result based on partner id in ascending order.
Note: Review is based on the following condition

IF rating>=4 ----> 'GOOD'
IF rating between >=2 and <4 -----> 'AVERAGE'
IF rating <2 ------------>'WORST'
(HINT : Use Delivery_partners table to retrieve records.)



SELECT partner_id, partner_name,
CASE WHEN rating>=4 THEN 'GOOD' 
WHEN rating>=2 AND rating<4 THEN 'AVERAGE' 
WHEN rating<2 THEN 'WORST' END AS REVIEW
FROM delivery_partners
ORDER BY partner_id ASC;