using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills_libs
{
    internal sealed class Acrobatic_skill:Skill_Class
    {
        #region // конструктор класса
        public Acrobatic_skill()  // определяем конструктор класса, используя конструктор базового класса
        {
            Set_cost(2);                        // Устанавиваем стоимость умения за очки опыта
            Set_score(0);                       // Устанавливаем текущее показатель умения 
            Set_counter(0);                     // Устанавливаем счетчик прокачки умения за очки опыта
            //Set_skill_code((int)SW_Character.enum_Skills.Acrobatic_skill); // устанавливаем уникальный код навыка
            Set_skill_description("");          // Устанавливаем текстовое описание навыка персонажа
            Set_path_read_description("");      // Устанавливаем путь к текстовому файлу с описанием навыка

            Set_child_skill_limit(3);           // Устанавливаем возрастной лимит прокачки навыка для Ребенок
            Set_teen_skill_limit(5);            // Устанавливаем возрастной лимит прокачки навыка для Подросток
            Set_adult_skill_limit(6);           // Устанавливаем возрастной лимит прокачки навыка для Взрослый
            Set_middle_skill_limit(10);         // Устанавливаем возрастной лимит прокачки навыка для Средний возраст
            Set_old_skill_limit(10);            // Устанавливаем возрастной лимит прокачки навыка для Пожилой возраст
            Set_eldery_skill_limit(10);         // Устанавливаем возрастной лимит прокачки навыка для Почтенный возраст
            Set_unknown_age_status_skill_limit(0); // Устанавливаем возрастной лимит прокачки навыка для Неизвестный возрастной ранг

            Set_private_skill_limit(5);         // Устанавливаем лимит прокачки навыка для Рядовой
            Set_veteran_skill_limit(10);        // Устанавливаем лимит прокачки навыка для Ветеран
            Set_hero_skill_limit(15);           // Устанавливаем лимит прокачки навыка для Герой
            Set_hero_skill_limit(20);           // Устанавливаем лимит прокачки навыка для Эпик
            Set_immortal_skill_limit(25);       // Устанавливаем лимит прокачки навыка для Бессмертный

            Set_is_combat_skill();              // Выставляем флаг, что навык является боевым
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного умения (если они есть)

        #endregion
    }
}
