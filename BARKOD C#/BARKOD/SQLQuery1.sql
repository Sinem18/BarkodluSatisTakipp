DECLARE @Sayac TINYINT
SET @Sayac=0
WHILE(@Sayac<25)
begin 
insert into HizliUrun(Barkod,UrunAd,Fiyat) values('-','-',0)
select @sayac=@sayac+1
end 