import Image from 'next/image'

import FeatImage01 from '@/public/images/Nada makram.jpg'
import FeatImage02 from '@/public/images/amr abdulwahab.jpg'
import FeatImage03 from '@/public/images/yousef nasser.jpg'

export default function Zigzag() {
  return (
    <section>
      <div className="max-w-6xl mx-auto px-4 sm:px-6">
        <div className="py-12 md:py-20 border-t border-gray-800">

          {/* Section header */}
          <div className="max-w-3xl mx-auto text-center pb-12 md:pb-16">
            <div className="inline-flex text-sm font-semibold py-1 px-3 m-2 text-green-600 bg-green-200 rounded-full mb-4">Our speakers!</div>
            <h1 className="h2 mb-4">Have a Look on our Speakers</h1>
           
          </div>

          {/* Items */}
          <div className="grid gap-20">

            {/* 1st item */}
            <div className="md:grid md:grid-cols-12 md:gap-6 items-center">
              {/* Image */}
              <div className="max-w-xl md:max-w-none md:w-full mx-auto md:col-span-5 lg:col-span-6 mb-8 md:mb-0 md:order-1" data-aos="fade-up">
                <Image className="max-w-full mx-auto md:max-w-none h-auto" src={FeatImage01} width={540} height={405} alt="Features 01" />
              </div>
              {/* Content */}
              <div className="max-w-xl md:max-w-none md:w-full mx-auto md:col-span-7 lg:col-span-6" data-aos="fade-right">
                <div className="md:pr-4 lg:pr-12 xl:pr-16">
                  <div className="font-architects-daughter text-xl text-purple-600 mb-2">Fashion designing</div>
                  <h3 className="h3 mb-3">Nada Akram</h3>
                  <p className="text-xl text-gray-400 mb-4">If you are a fashion designer, how can you let people know that these are your designs without a logo?!
This was one of the challenges I met with Nada Akram, a fashion designer who founded her brand in 2011, and her idea was to add a modern touch to the Egyptian identity and design comfortable clothes with an edge to meet the tastes of every age group!
Nada Akram started designing T-shirts until she discovered that her designs were easily stolen and posted on the Internet. At that time, she decided that in order to make her designs difficult to imitate, she would design her own fabric. Even the prints on the T-shirts were drawn.
Nada loves happy prints like gummy bears, cupcakes, popcorn, and her own trade marks, so when people see these prints, they know they belong to Nada Akram, and this helped her make people recognize her designs without the logo.</p>
                  <ul className="text-lg text-gray-400 -mb-2">
                    <li className="flex items-center mb-2">
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                      
                    </li>
                    <li className="flex items-center mb-2">
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                      
                    </li>
                    <li className="flex items-center">
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                      
                    </li>
                  </ul>
                </div>
              </div>
            </div>

            {/* 2nd item */}
            <div className="md:grid md:grid-cols-12 md:gap-6 items-center">
              {/* Image */}
              <div className="max-w-xl md:max-w-none md:w-full mx-auto md:col-span-5 lg:col-span-6 mb-8 md:mb-0 rtl" data-aos="fade-up">
                <Image className="max-w-full mx-auto md:max-w-none h-auto" src={FeatImage02} width={540} height={405} alt="Features 02" />
              </div>
              {/* Content */}
              <div className="max-w-xl md:max-w-none md:w-full mx-auto md:col-span-7 lg:col-span-6" data-aos="fade-left">
                <div className="md:pl-4 lg:pl-12 xl:pl-16">
                  <div className="font-architects-daughter text-xl text-purple-600 mb-2">Astrophysicist</div>
                  <h3 className="h3 mb-3">Amr Abdelwahab</h3>
                  <p className="text-xl text-gray-400 mb-4">Who among us is enchanted by the stars of the sky and lost in their beauty?!
Amr Abdel Wahab is exactly like us, but the nature of Upper Egypt and the lack of light pollution helped the stars capture his heart. No, he also bought a camera so he could start photographing and documenting the beautiful moments he sees with his own eyes. Amr Abdel Wahab is currently the president of the Dr. Mostafa Mahmoud Astronomical Society, which is the oldest astronomical group in this Arab world. However, he organizes trips through his agency. This is in addition to his academy (Astronomy Academy), where he helps children and adults learn about astronomy and space science.
Amr Abdel Wahab organizes regular workshops in the Western Desert to photograph the stars that are captured in the light from the heart of the darkness of the desert.</p>
                  <ul className="text-lg text-gray-400 -mb-2">
                    <li className="flex items-center mb-2">
                      
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                    
                    </li>
                    <li className="flex items-center mb-2">
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                     
                    </li>
                    <li className="flex items-center">
                      
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                
                    </li>
                  </ul>
                </div>
              </div>
            </div>

            {/* 3rd item */}
            <div className="md:grid md:grid-cols-12 md:gap-6 items-center">
              {/* Image */}
              <div className="max-w-xl md:max-w-none md:w-full mx-auto md:col-span-5 lg:col-span-6 mb-8 md:mb-0 md:order-1" data-aos="fade-up">
                <Image className="max-w-full mx-auto md:max-w-none h-auto" src={FeatImage03} width={540} height={405} alt="Features 03" />
              </div>
              {/* Content */}
              <div className="max-w-xl md:max-w-none md:w-full mx-auto md:col-span-7 lg:col-span-6" data-aos="fade-right">
                <div className="md:pr-4 lg:pr-12 xl:pr-16">
                  <div className="font-architects-daughter text-xl text-purple-600 mb-2">Photographer</div>
                  <h3 className="h3 mb-3">Youssef Naser</h3>
                  <p className="text-xl text-gray-400 mb-4">The annual festival is more focused on the arts, and that is why the annual speakers must be artists of the highest level.
The club will be with us, the talented Youssef Nasser, who won the title of Best Young Amateur Photographer 2022. He also won photography awards from the American Photographic Society, the World Photography Federation, the German Photography Cup, the Arab Photographers Union, the Egypt Press Photo Competition 2022, and the Fujifilm Egypt Award. 2022, the Lens Photography Club, and the Sakia Photography Competition 2022. He presented his works at the Egypt Press Photo Exhibition for 2021, the First Time Exhibition for 2022 at the Bibliotheca Alexandria, and the Youth Art Salon for the years 2021 and 2022, which is organized by the Ministry of Culture.</p>
                  <ul className="text-lg text-gray-400 -mb-2">
                    <li className="flex items-center mb-2">
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                      
                    </li>
                    <li className="flex items-center mb-2">
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                      
                    </li>
                    <li className="flex items-center">
                      
                        <path d="M10.28 2.28L3.989 8.575 1.695 6.28A1 1 0 00.28 7.695l3 3a1 1 0 001.414 0l7-7A1 1 0 0010.28 2.28z" />
                      
                    </li>
                  </ul>
                </div>
              </div>
            </div>

          </div>

        </div>
      </div>
    </section>
  )
}
