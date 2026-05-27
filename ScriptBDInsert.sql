--
-- PostgreSQL database dump
--

\restrict aqmm7LWyMpZfoDzRhf7gPJB6rzIYzBCETr0eVTSjRJnSu9lTdi06oG8SpFiVOcN

-- Dumped from database version 18.4
-- Dumped by pg_dump version 18.3

-- Started on 2026-05-25 19:11:34

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 228 (class 1259 OID 41023)
-- Name: categories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.categories (
    category_id integer NOT NULL,
    category_name character varying(100) NOT NULL
);


ALTER TABLE public.categories OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 41022)
-- Name: categories_category_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.categories_category_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.categories_category_id_seq OWNER TO postgres;

--
-- TOC entry 5127 (class 0 OID 0)
-- Dependencies: 227
-- Name: categories_category_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.categories_category_id_seq OWNED BY public.categories.category_id;


--
-- TOC entry 224 (class 1259 OID 41001)
-- Name: manufacturers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.manufacturers (
    manufacturer_id integer NOT NULL,
    manufacturer_name character varying(100) NOT NULL
);


ALTER TABLE public.manufacturers OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 41000)
-- Name: manufacturers_manufacturer_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.manufacturers_manufacturer_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.manufacturers_manufacturer_id_seq OWNER TO postgres;

--
-- TOC entry 5128 (class 0 OID 0)
-- Dependencies: 223
-- Name: manufacturers_manufacturer_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.manufacturers_manufacturer_id_seq OWNED BY public.manufacturers.manufacturer_id;


--
-- TOC entry 238 (class 1259 OID 41190)
-- Name: order_products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.order_products (
    order_products_id integer NOT NULL,
    order_id integer NOT NULL,
    product_id integer NOT NULL,
    quantity integer NOT NULL
);


ALTER TABLE public.order_products OWNER TO postgres;

--
-- TOC entry 237 (class 1259 OID 41189)
-- Name: order_products_order_products_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.order_products_order_products_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.order_products_order_products_id_seq OWNER TO postgres;

--
-- TOC entry 5129 (class 0 OID 0)
-- Dependencies: 237
-- Name: order_products_order_products_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.order_products_order_products_id_seq OWNED BY public.order_products.order_products_id;


--
-- TOC entry 234 (class 1259 OID 41161)
-- Name: order_statuses; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.order_statuses (
    status_id integer NOT NULL,
    status_name character varying(100) NOT NULL
);


ALTER TABLE public.order_statuses OWNER TO postgres;

--
-- TOC entry 233 (class 1259 OID 41160)
-- Name: order_statuses_status_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.order_statuses_status_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.order_statuses_status_id_seq OWNER TO postgres;

--
-- TOC entry 5130 (class 0 OID 0)
-- Dependencies: 233
-- Name: order_statuses_status_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.order_statuses_status_id_seq OWNED BY public.order_statuses.status_id;


--
-- TOC entry 236 (class 1259 OID 41170)
-- Name: orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orders (
    order_id integer NOT NULL,
    order_date date,
    issue_date date,
    pickup_point_id integer NOT NULL,
    order_fio character varying(255),
    receive_code integer,
    status_id integer NOT NULL
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- TOC entry 235 (class 1259 OID 41169)
-- Name: orders_order_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.orders_order_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.orders_order_id_seq OWNER TO postgres;

--
-- TOC entry 5131 (class 0 OID 0)
-- Dependencies: 235
-- Name: orders_order_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.orders_order_id_seq OWNED BY public.orders.order_id;


--
-- TOC entry 232 (class 1259 OID 41150)
-- Name: pickup_points; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pickup_points (
    pickup_point_id integer NOT NULL,
    address text NOT NULL
);


ALTER TABLE public.pickup_points OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 41149)
-- Name: pickup_points_pickup_point_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pickup_points_pickup_point_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.pickup_points_pickup_point_id_seq OWNER TO postgres;

--
-- TOC entry 5132 (class 0 OID 0)
-- Dependencies: 231
-- Name: pickup_points_pickup_point_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pickup_points_pickup_point_id_seq OWNED BY public.pickup_points.pickup_point_id;


--
-- TOC entry 230 (class 1259 OID 41112)
-- Name: products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.products (
    product_id integer NOT NULL,
    article character varying(50) NOT NULL,
    product_name character varying(255) NOT NULL,
    unit character varying(20) NOT NULL,
    price numeric(10,2) NOT NULL,
    category_id integer NOT NULL,
    manufacturer_id integer NOT NULL,
    supplier_id integer NOT NULL,
    discount integer DEFAULT 0 NOT NULL,
    quantity integer DEFAULT 0 NOT NULL,
    description text,
    image_path character varying(255)
);


ALTER TABLE public.products OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 41111)
-- Name: products_product_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.products_product_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.products_product_id_seq OWNER TO postgres;

--
-- TOC entry 5133 (class 0 OID 0)
-- Dependencies: 229
-- Name: products_product_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.products_product_id_seq OWNED BY public.products.product_id;


--
-- TOC entry 220 (class 1259 OID 40971)
-- Name: roles; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.roles (
    role_id integer NOT NULL,
    role_name character varying(100) NOT NULL
);


ALTER TABLE public.roles OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 40970)
-- Name: roles_role_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.roles_role_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.roles_role_id_seq OWNER TO postgres;

--
-- TOC entry 5134 (class 0 OID 0)
-- Dependencies: 219
-- Name: roles_role_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.roles_role_id_seq OWNED BY public.roles.role_id;


--
-- TOC entry 226 (class 1259 OID 41010)
-- Name: suppliers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.suppliers (
    supplier_id integer NOT NULL,
    supplier_name character varying(100) NOT NULL
);


ALTER TABLE public.suppliers OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 41009)
-- Name: suppliers_supplier_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.suppliers_supplier_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.suppliers_supplier_id_seq OWNER TO postgres;

--
-- TOC entry 5135 (class 0 OID 0)
-- Dependencies: 225
-- Name: suppliers_supplier_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.suppliers_supplier_id_seq OWNED BY public.suppliers.supplier_id;


--
-- TOC entry 222 (class 1259 OID 40982)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    user_id integer NOT NULL,
    role_id integer NOT NULL,
    fio character varying(255) NOT NULL,
    login character varying(100) NOT NULL,
    password character varying(50) NOT NULL
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 40981)
-- Name: users_user_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.users_user_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.users_user_id_seq OWNER TO postgres;

--
-- TOC entry 5136 (class 0 OID 0)
-- Dependencies: 221
-- Name: users_user_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.users_user_id_seq OWNED BY public.users.user_id;


--
-- TOC entry 4905 (class 2604 OID 41026)
-- Name: categories category_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categories ALTER COLUMN category_id SET DEFAULT nextval('public.categories_category_id_seq'::regclass);


--
-- TOC entry 4903 (class 2604 OID 41004)
-- Name: manufacturers manufacturer_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.manufacturers ALTER COLUMN manufacturer_id SET DEFAULT nextval('public.manufacturers_manufacturer_id_seq'::regclass);


--
-- TOC entry 4912 (class 2604 OID 41193)
-- Name: order_products order_products_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_products ALTER COLUMN order_products_id SET DEFAULT nextval('public.order_products_order_products_id_seq'::regclass);


--
-- TOC entry 4910 (class 2604 OID 41164)
-- Name: order_statuses status_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_statuses ALTER COLUMN status_id SET DEFAULT nextval('public.order_statuses_status_id_seq'::regclass);


--
-- TOC entry 4911 (class 2604 OID 41173)
-- Name: orders order_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders ALTER COLUMN order_id SET DEFAULT nextval('public.orders_order_id_seq'::regclass);


--
-- TOC entry 4909 (class 2604 OID 41153)
-- Name: pickup_points pickup_point_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pickup_points ALTER COLUMN pickup_point_id SET DEFAULT nextval('public.pickup_points_pickup_point_id_seq'::regclass);


--
-- TOC entry 4906 (class 2604 OID 41115)
-- Name: products product_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products ALTER COLUMN product_id SET DEFAULT nextval('public.products_product_id_seq'::regclass);


--
-- TOC entry 4901 (class 2604 OID 40974)
-- Name: roles role_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.roles ALTER COLUMN role_id SET DEFAULT nextval('public.roles_role_id_seq'::regclass);


--
-- TOC entry 4904 (class 2604 OID 41013)
-- Name: suppliers supplier_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.suppliers ALTER COLUMN supplier_id SET DEFAULT nextval('public.suppliers_supplier_id_seq'::regclass);


--
-- TOC entry 4902 (class 2604 OID 40985)
-- Name: users user_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users ALTER COLUMN user_id SET DEFAULT nextval('public.users_user_id_seq'::regclass);


--
-- TOC entry 5111 (class 0 OID 41023)
-- Dependencies: 228
-- Data for Name: categories; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.categories VALUES (1, 'Женская обувь');
INSERT INTO public.categories VALUES (2, 'Мужская обувь');


--
-- TOC entry 5107 (class 0 OID 41001)
-- Dependencies: 224
-- Data for Name: manufacturers; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.manufacturers VALUES (1, 'Kari');
INSERT INTO public.manufacturers VALUES (2, 'Marco Tozzi');
INSERT INTO public.manufacturers VALUES (3, 'Poc');
INSERT INTO public.manufacturers VALUES (4, 'Rieker');
INSERT INTO public.manufacturers VALUES (5, 'Alessio Nesca');
INSERT INTO public.manufacturers VALUES (6, 'CROSBY');


--
-- TOC entry 5121 (class 0 OID 41190)
-- Dependencies: 238
-- Data for Name: order_products; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.order_products VALUES (1, 1, 1, 2);
INSERT INTO public.order_products VALUES (2, 2, 3, 1);
INSERT INTO public.order_products VALUES (3, 3, 5, 10);
INSERT INTO public.order_products VALUES (4, 4, 7, 5);
INSERT INTO public.order_products VALUES (5, 5, 1, 2);
INSERT INTO public.order_products VALUES (6, 6, 3, 1);
INSERT INTO public.order_products VALUES (7, 7, 5, 10);
INSERT INTO public.order_products VALUES (8, 8, 7, 5);
INSERT INTO public.order_products VALUES (9, 9, 9, 5);
INSERT INTO public.order_products VALUES (10, 10, 11, 5);
INSERT INTO public.order_products VALUES (11, 1, 2, 2);
INSERT INTO public.order_products VALUES (12, 2, 4, 1);
INSERT INTO public.order_products VALUES (13, 3, 6, 10);
INSERT INTO public.order_products VALUES (14, 4, 8, 4);
INSERT INTO public.order_products VALUES (15, 5, 2, 2);
INSERT INTO public.order_products VALUES (16, 6, 4, 1);
INSERT INTO public.order_products VALUES (17, 7, 6, 10);
INSERT INTO public.order_products VALUES (18, 8, 8, 4);
INSERT INTO public.order_products VALUES (19, 9, 10, 1);
INSERT INTO public.order_products VALUES (20, 10, 12, 5);


--
-- TOC entry 5117 (class 0 OID 41161)
-- Dependencies: 234
-- Data for Name: order_statuses; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.order_statuses VALUES (1, 'Завершен');
INSERT INTO public.order_statuses VALUES (2, 'Новый');


--
-- TOC entry 5119 (class 0 OID 41170)
-- Dependencies: 236
-- Data for Name: orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.orders VALUES (1, '2025-02-27', '2025-04-20', 1, 'Степанов Михаил Артёмович', 901, 1);
INSERT INTO public.orders VALUES (2, '2022-09-28', '2025-04-21', 11, 'Никифорова Весения Николаевна', 902, 1);
INSERT INTO public.orders VALUES (3, '2025-03-21', '2025-04-22', 2, 'Сазонов Руслан Германович', 903, 1);
INSERT INTO public.orders VALUES (4, '2025-02-20', '2025-04-23', 11, 'Одинцов Серафим Артёмович', 904, 1);
INSERT INTO public.orders VALUES (5, '2025-03-17', '2025-04-24', 2, 'Степанов Михаил Артёмович', 905, 1);
INSERT INTO public.orders VALUES (6, '2025-03-01', '2025-04-25', 15, 'Никифорова Весения Николаевна', 906, 1);
INSERT INTO public.orders VALUES (7, '2025-02-27', '2025-04-26', 3, 'Сазонов Руслан Германович', 907, 1);
INSERT INTO public.orders VALUES (8, '2025-03-31', '2025-04-27', 19, 'Одинцов Серафим Артёмович', 908, 2);
INSERT INTO public.orders VALUES (9, '2025-04-02', '2025-04-28', 5, 'Степанов Михаил Артёмович', 909, 2);
INSERT INTO public.orders VALUES (10, '2025-04-03', '2025-04-29', 19, 'Степанов Михаил Артёмович', 910, 2);


--
-- TOC entry 5115 (class 0 OID 41150)
-- Dependencies: 232
-- Data for Name: pickup_points; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.pickup_points VALUES (1, '﻿420151, г. Лесной, ул. Вишневая, 32');
INSERT INTO public.pickup_points VALUES (2, '125061, г. Лесной, ул. Подгорная, 8');
INSERT INTO public.pickup_points VALUES (3, '630370, г. Лесной, ул. Шоссейная, 24');
INSERT INTO public.pickup_points VALUES (4, '400562, г. Лесной, ул. Зеленая, 32');
INSERT INTO public.pickup_points VALUES (5, '614510, г. Лесной, ул. Маяковского, 47');
INSERT INTO public.pickup_points VALUES (6, '410542, г. Лесной, ул. Светлая, 46');
INSERT INTO public.pickup_points VALUES (7, '620839, г. Лесной, ул. Цветочная, 8');
INSERT INTO public.pickup_points VALUES (8, '443890, г. Лесной, ул. Коммунистическая, 1');
INSERT INTO public.pickup_points VALUES (9, '603379, г. Лесной, ул. Спортивная, 46');
INSERT INTO public.pickup_points VALUES (10, '603721, г. Лесной, ул. Гоголя, 41');
INSERT INTO public.pickup_points VALUES (11, '410172, г. Лесной, ул. Северная, 13');
INSERT INTO public.pickup_points VALUES (12, '614611, г. Лесной, ул. Молодежная, 50');
INSERT INTO public.pickup_points VALUES (13, '454311, г.Лесной, ул. Новая, 19');
INSERT INTO public.pickup_points VALUES (14, '660007, г.Лесной, ул. Октябрьская, 19');
INSERT INTO public.pickup_points VALUES (15, '603036, г. Лесной, ул. Садовая, 4');
INSERT INTO public.pickup_points VALUES (16, '394060, г.Лесной, ул. Фрунзе, 43');
INSERT INTO public.pickup_points VALUES (17, '410661, г. Лесной, ул. Школьная, 50');
INSERT INTO public.pickup_points VALUES (18, '625590, г. Лесной, ул. Коммунистическая, 20');
INSERT INTO public.pickup_points VALUES (19, '625683, г. Лесной, ул. 8 Марта');
INSERT INTO public.pickup_points VALUES (20, '450983, г.Лесной, ул. Комсомольская, 26');
INSERT INTO public.pickup_points VALUES (21, '394782, г. Лесной, ул. Чехова, 3');
INSERT INTO public.pickup_points VALUES (22, '603002, г. Лесной, ул. Дзержинского, 28');
INSERT INTO public.pickup_points VALUES (23, '450558, г. Лесной, ул. Набережная, 30');
INSERT INTO public.pickup_points VALUES (24, '344288, г. Лесной, ул. Чехова, 1');
INSERT INTO public.pickup_points VALUES (25, '614164, г.Лесной,  ул. Степная, 30');
INSERT INTO public.pickup_points VALUES (26, '394242, г. Лесной, ул. Коммунистическая, 43');
INSERT INTO public.pickup_points VALUES (27, '660540, г. Лесной, ул. Солнечная, 25');
INSERT INTO public.pickup_points VALUES (28, '125837, г. Лесной, ул. Шоссейная, 40');
INSERT INTO public.pickup_points VALUES (29, '125703, г. Лесной, ул. Партизанская, 49');
INSERT INTO public.pickup_points VALUES (30, '625283, г. Лесной, ул. Победы, 46');
INSERT INTO public.pickup_points VALUES (31, '614753, г. Лесной, ул. Полевая, 35');
INSERT INTO public.pickup_points VALUES (32, '426030, г. Лесной, ул. Маяковского, 44');
INSERT INTO public.pickup_points VALUES (33, '450375, г. Лесной ул. Клубная, 44');
INSERT INTO public.pickup_points VALUES (34, '625560, г. Лесной, ул. Некрасова, 12');
INSERT INTO public.pickup_points VALUES (35, '630201, г. Лесной, ул. Комсомольская, 17');
INSERT INTO public.pickup_points VALUES (36, '190949, г. Лесной, ул. Мичурина, 26');


--
-- TOC entry 5113 (class 0 OID 41112)
-- Dependencies: 230
-- Data for Name: products; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.products VALUES (1, 'А112Т4', 'Ботинки', 'шт.', 4990.00, 1, 1, 1, 3, 6, 'Женские Ботинки демисезонные kari', 'images/1.jpg');
INSERT INTO public.products VALUES (2, 'F635R4', 'Ботинки', 'шт.', 3244.00, 1, 2, 2, 2, 13, 'Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый', 'images/2.jpg');
INSERT INTO public.products VALUES (3, 'H782T5', 'Туфли', 'шт.', 4499.00, 2, 1, 1, 4, 5, 'Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный', 'images/3.jpg');
INSERT INTO public.products VALUES (4, 'G783F5', 'Ботинки', 'шт.', 5900.00, 2, 3, 1, 2, 8, 'Мужские ботинки Рос-Обувь кожаные с натуральным мехом', 'images/4.jpg');
INSERT INTO public.products VALUES (5, 'J384T6', 'Ботинки', 'шт.', 3800.00, 2, 4, 2, 2, 16, 'B3430/14 Полуботинки мужские Rieker', 'images/5.jpg');
INSERT INTO public.products VALUES (6, 'D572U8', 'Кроссовки', 'шт.', 4100.00, 2, 3, 2, 3, 6, '129615-4 Кроссовки мужские', 'images/6.jpg');
INSERT INTO public.products VALUES (7, 'F572H7', 'Туфли', 'шт.', 2700.00, 1, 2, 1, 2, 14, 'Туфли Marco Tozzi женские летние, размер 39, цвет черный', 'images/7.jpg');
INSERT INTO public.products VALUES (8, 'D329H3', 'Полуботинки', 'шт.', 1890.00, 1, 5, 2, 4, 4, 'Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый', 'images/8.jpg');
INSERT INTO public.products VALUES (9, 'B320R5', 'Туфли', 'шт.', 4300.00, 1, 4, 1, 2, 6, 'Туфли Rieker женские демисезонные, размер 41, цвет коричневый', 'images/9.jpg');
INSERT INTO public.products VALUES (10, 'G432E4', 'Туфли', 'шт.', 2800.00, 1, 1, 1, 3, 15, 'Туфли kari женские TR-YR-413017, размер 37, цвет: черный', 'images/10.jpg');
INSERT INTO public.products VALUES (11, 'S213E3', 'Полуботинки', 'шт.', 2156.00, 2, 6, 2, 3, 6, '407700/01-01 Полуботинки мужские CROSBY', NULL);
INSERT INTO public.products VALUES (12, 'E482R4', 'Полуботинки', 'шт.', 1800.00, 1, 1, 1, 2, 14, 'Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный', NULL);
INSERT INTO public.products VALUES (13, 'S634B5', 'Кеды', 'шт.', 5500.00, 2, 6, 2, 3, 0, 'Кеды Caprice мужские демисезонные, размер 42, цвет черный', NULL);
INSERT INTO public.products VALUES (14, 'K345R4', 'Полуботинки', 'шт.', 2100.00, 2, 6, 2, 2, 3, '407700/01-02 Полуботинки мужские CROSBY', NULL);
INSERT INTO public.products VALUES (15, 'O754F4', 'Туфли', 'шт.', 5400.00, 1, 4, 2, 4, 18, 'Туфли женские демисезонные Rieker артикул 55073-68/37', NULL);
INSERT INTO public.products VALUES (16, 'G531F4', 'Ботинки', 'шт.', 6600.00, 1, 1, 1, 12, 9, 'Ботинки женские зимние ROMER арт. 893167-01 Черный', NULL);
INSERT INTO public.products VALUES (17, 'J542F5', 'Тапочки', 'шт.', 500.00, 2, 1, 1, 13, 0, 'Тапочки мужские Арт.70701-55-67син р.41', NULL);
INSERT INTO public.products VALUES (18, 'B431R5', 'Ботинки', 'шт.', 2700.00, 2, 4, 2, 2, 5, 'Мужские кожаные ботинки/мужские ботинки', NULL);
INSERT INTO public.products VALUES (19, 'P764G4', 'Туфли', 'шт.', 6800.00, 1, 6, 1, 15, 15, 'Туфли женские, ARGO, размер 38', NULL);
INSERT INTO public.products VALUES (20, 'C436G5', 'Ботинки', 'шт.', 10200.00, 1, 5, 1, 15, 9, 'Ботинки женские, ARGO, размер 40', NULL);
INSERT INTO public.products VALUES (21, 'F427R5', 'Ботинки', 'шт.', 11800.00, 1, 4, 2, 15, 11, 'Ботинки на молнии с декоративной пряжкой FRAU', NULL);
INSERT INTO public.products VALUES (22, 'N457T5', 'Полуботинки', 'шт.', 4600.00, 1, 6, 1, 3, 13, 'Полуботинки Ботинки черные зимние, мех', NULL);
INSERT INTO public.products VALUES (23, 'D364R4', 'Туфли', 'шт.', 12400.00, 1, 1, 1, 16, 5, 'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши', NULL);
INSERT INTO public.products VALUES (24, 'S326R5', 'Тапочки', 'шт.', 9900.00, 2, 6, 2, 17, 15, 'Мужские кожаные тапочки Профиль С.Дали ', NULL);
INSERT INTO public.products VALUES (25, 'L754R4', 'Полуботинки', 'шт.', 1700.00, 1, 1, 1, 2, 7, 'Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный', NULL);
INSERT INTO public.products VALUES (26, 'M542T5', 'Кроссовки', 'шт.', 2800.00, 2, 4, 2, 18, 3, 'Кроссовки мужские TOFA', NULL);
INSERT INTO public.products VALUES (27, 'D268G5', 'Туфли', 'шт.', 4399.00, 1, 4, 2, 3, 12, 'Туфли Rieker женские демисезонные, размер 36, цвет коричневый', NULL);
INSERT INTO public.products VALUES (28, 'T324F5', 'Сапоги', 'шт.', 4699.00, 1, 6, 1, 2, 5, 'Сапоги замша Цвет: синий', NULL);
INSERT INTO public.products VALUES (29, 'K358H6', 'Тапочки', 'шт.', 599.00, 2, 4, 1, 20, 2, 'Тапочки мужские син р.41', NULL);
INSERT INTO public.products VALUES (30, 'H535R5', 'Ботинки', 'шт.', 2300.00, 1, 4, 2, 2, 7, 'Женские Ботинки демисезонные', NULL);


--
-- TOC entry 5103 (class 0 OID 40971)
-- Dependencies: 220
-- Data for Name: roles; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.roles VALUES (1, 'Администратор');
INSERT INTO public.roles VALUES (2, 'Менеджер');
INSERT INTO public.roles VALUES (3, 'Авторизованный клиент');


--
-- TOC entry 5109 (class 0 OID 41010)
-- Dependencies: 226
-- Data for Name: suppliers; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.suppliers VALUES (1, 'Kari');
INSERT INTO public.suppliers VALUES (2, 'Обувь для вас');


--
-- TOC entry 5105 (class 0 OID 40982)
-- Dependencies: 222
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.users VALUES (1, 1, 'Никифорова Весения Николаевна', '94d5ous@gmail.com', 'uzWC67');
INSERT INTO public.users VALUES (2, 1, 'Сазонов Руслан Германович', 'uth4iz@mail.com', '2L6KZG');
INSERT INTO public.users VALUES (3, 1, 'Одинцов Серафим Артёмович', 'yzls62@outlook.com', 'JlFRCZ');
INSERT INTO public.users VALUES (4, 2, 'Степанов Михаил Артёмович', '1diph5e@tutanota.com', '8ntwUp');
INSERT INTO public.users VALUES (5, 2, 'Ворсин Петр Евгеньевич', 'tjde7c@yahoo.com', 'YOyhfR');
INSERT INTO public.users VALUES (6, 2, 'Старикова Елена Павловна', 'wpmrc3do@tutanota.com', 'RSbvHv');
INSERT INTO public.users VALUES (7, 3, 'Михайлюк Анна Вячеславовна', '5d4zbu@tutanota.com', 'rwVDh9');
INSERT INTO public.users VALUES (8, 3, 'Ситдикова Елена Анатольевна', 'ptec8ym@yahoo.com', 'LdNyos');
INSERT INTO public.users VALUES (9, 3, 'Ворсин Петр Евгеньевич', '1qz4kw@mail.com', 'gynQMT');
INSERT INTO public.users VALUES (10, 3, 'Старикова Елена Павловна', '4np6se@mail.com', 'AtnDjr');


--
-- TOC entry 5137 (class 0 OID 0)
-- Dependencies: 227
-- Name: categories_category_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.categories_category_id_seq', 2, true);


--
-- TOC entry 5138 (class 0 OID 0)
-- Dependencies: 223
-- Name: manufacturers_manufacturer_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.manufacturers_manufacturer_id_seq', 6, true);


--
-- TOC entry 5139 (class 0 OID 0)
-- Dependencies: 237
-- Name: order_products_order_products_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.order_products_order_products_id_seq', 20, true);


--
-- TOC entry 5140 (class 0 OID 0)
-- Dependencies: 233
-- Name: order_statuses_status_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.order_statuses_status_id_seq', 2, true);


--
-- TOC entry 5141 (class 0 OID 0)
-- Dependencies: 235
-- Name: orders_order_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.orders_order_id_seq', 10, true);


--
-- TOC entry 5142 (class 0 OID 0)
-- Dependencies: 231
-- Name: pickup_points_pickup_point_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pickup_points_pickup_point_id_seq', 36, true);


--
-- TOC entry 5143 (class 0 OID 0)
-- Dependencies: 229
-- Name: products_product_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.products_product_id_seq', 30, true);


--
-- TOC entry 5144 (class 0 OID 0)
-- Dependencies: 219
-- Name: roles_role_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.roles_role_id_seq', 3, true);


--
-- TOC entry 5145 (class 0 OID 0)
-- Dependencies: 225
-- Name: suppliers_supplier_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.suppliers_supplier_id_seq', 2, true);


--
-- TOC entry 5146 (class 0 OID 0)
-- Dependencies: 221
-- Name: users_user_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.users_user_id_seq', 10, true);


--
-- TOC entry 4930 (class 2606 OID 41032)
-- Name: categories categories_category_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_category_name_key UNIQUE (category_name);


--
-- TOC entry 4932 (class 2606 OID 41080)
-- Name: categories categories_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categories
    ADD CONSTRAINT categories_pkey PRIMARY KEY (category_id);


--
-- TOC entry 4922 (class 2606 OID 41021)
-- Name: manufacturers manufacturers_manufacturer_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.manufacturers
    ADD CONSTRAINT manufacturers_manufacturer_name_key UNIQUE (manufacturer_name);


--
-- TOC entry 4924 (class 2606 OID 41110)
-- Name: manufacturers manufacturers_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.manufacturers
    ADD CONSTRAINT manufacturers_pkey PRIMARY KEY (manufacturer_id);


--
-- TOC entry 4946 (class 2606 OID 41199)
-- Name: order_products order_products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_products
    ADD CONSTRAINT order_products_pkey PRIMARY KEY (order_products_id);


--
-- TOC entry 4940 (class 2606 OID 41168)
-- Name: order_statuses order_statuses_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_statuses
    ADD CONSTRAINT order_statuses_pkey PRIMARY KEY (status_id);


--
-- TOC entry 4942 (class 2606 OID 41211)
-- Name: order_statuses order_statuses_status_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_statuses
    ADD CONSTRAINT order_statuses_status_name_key UNIQUE (status_name);


--
-- TOC entry 4944 (class 2606 OID 41178)
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (order_id);


--
-- TOC entry 4938 (class 2606 OID 41159)
-- Name: pickup_points pickup_points_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pickup_points
    ADD CONSTRAINT pickup_points_pkey PRIMARY KEY (pickup_point_id);


--
-- TOC entry 4934 (class 2606 OID 41133)
-- Name: products products_article_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_article_key UNIQUE (article);


--
-- TOC entry 4936 (class 2606 OID 41131)
-- Name: products products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (product_id);


--
-- TOC entry 4914 (class 2606 OID 40978)
-- Name: roles roles_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (role_id);


--
-- TOC entry 4916 (class 2606 OID 40980)
-- Name: roles roles_role_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_role_name_key UNIQUE (role_name);


--
-- TOC entry 4926 (class 2606 OID 41017)
-- Name: suppliers suppliers_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.suppliers
    ADD CONSTRAINT suppliers_pkey PRIMARY KEY (supplier_id);


--
-- TOC entry 4928 (class 2606 OID 41019)
-- Name: suppliers suppliers_supplier_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.suppliers
    ADD CONSTRAINT suppliers_supplier_name_key UNIQUE (supplier_name);


--
-- TOC entry 4918 (class 2606 OID 40994)
-- Name: users users_login_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_login_key UNIQUE (login);


--
-- TOC entry 4920 (class 2606 OID 40992)
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (user_id);


--
-- TOC entry 4953 (class 2606 OID 41200)
-- Name: order_products order_products_order_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_products
    ADD CONSTRAINT order_products_order_id_fkey FOREIGN KEY (order_id) REFERENCES public.orders(order_id) ON DELETE CASCADE;


--
-- TOC entry 4954 (class 2606 OID 41205)
-- Name: order_products order_products_product_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_products
    ADD CONSTRAINT order_products_product_id_fkey FOREIGN KEY (product_id) REFERENCES public.products(product_id);


--
-- TOC entry 4951 (class 2606 OID 41179)
-- Name: orders orders_pickup_point_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pickup_point_id_fkey FOREIGN KEY (pickup_point_id) REFERENCES public.pickup_points(pickup_point_id);


--
-- TOC entry 4952 (class 2606 OID 41184)
-- Name: orders orders_status_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_status_id_fkey FOREIGN KEY (status_id) REFERENCES public.order_statuses(status_id);


--
-- TOC entry 4948 (class 2606 OID 41134)
-- Name: products products_category_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_category_id_fkey FOREIGN KEY (category_id) REFERENCES public.categories(category_id);


--
-- TOC entry 4949 (class 2606 OID 41139)
-- Name: products products_manufacturer_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_manufacturer_id_fkey FOREIGN KEY (manufacturer_id) REFERENCES public.manufacturers(manufacturer_id);


--
-- TOC entry 4950 (class 2606 OID 41144)
-- Name: products products_supplier_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_supplier_id_fkey FOREIGN KEY (supplier_id) REFERENCES public.suppliers(supplier_id);


--
-- TOC entry 4947 (class 2606 OID 40995)
-- Name: users users_role_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_role_id_fkey FOREIGN KEY (role_id) REFERENCES public.roles(role_id);


-- Completed on 2026-05-25 19:11:35

--
-- PostgreSQL database dump complete
--

\unrestrict aqmm7LWyMpZfoDzRhf7gPJB6rzIYzBCETr0eVTSjRJnSu9lTdi06oG8SpFiVOcN

