# Kahve Sipariş Uygulaması

## Tanım
bu proje .Net MVC çerçevesi altında geliştirilmiştir. Amaç, anasayfa içerisinde dummy data olarak oluşturulan kahvelerin listelenmesi ve bu kahve içerisinde bulunan ebatlardan seçim yapılarak sepet içerisinde tutulmasını sağlamaktır. Bu anlamda proje mimarisi aşağıdaki gibi tanımlanmıştır.

## Proje Yapısı
- Models
	- Entities
		- Coffee
		- FilterCoffee
		- Espresso
		- Latte
		- Order
- ViewModels
		- CartViewModel
- Data
	- SeedCoffeeData
	- OrderData
	- CartData
- Controllers
	- HomeController
		- Index
	- OrderController
		- Create

## Views
- Home/Index: SeedCoffeeData içerisinde bulunan bütün kahvelerin listelendiği sayfadır. Bu sayfa içerisinde ziyaretçiler sepete istedikleri kahveyi ekleyebilirler. Oluşturulan sepet içerisindeki kahveler sipariş olarak tanımlanırlar.

----------

## Yarın işlenecekler
- Cookie Mantığı
- Session Mantığı
- Area işlemleri
- Repository pattern
- Service pattern
- Katmanlı mimari
- Api 
